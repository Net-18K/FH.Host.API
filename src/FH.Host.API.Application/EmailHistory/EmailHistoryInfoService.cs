using FH.Host.API.Application.EmailHistory.Dto;
using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Infrastructure.Email;
using FH.Host.API.Infrastructure.Model;
using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FH.Host.API.Application.EmailHistory
{
    /// <summary>
    /// 邮件历史信息服务
    /// </summary>
    [Route("api/EmailHistoryInfo")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    [Authorize]
    public class EmailHistoryInfoService
    {
        private readonly IOwnerRepository<FH_EmailHistoryInfo> _context;
        private readonly IEmailServices _emailServices;

        public EmailHistoryInfoService(IOwnerRepository<FH_EmailHistoryInfo> context,
            IEmailServices emailServices)
        {
            _context = context;
            _emailServices = emailServices;
        }

        /// <summary>
        /// 得到所有邮件历史信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllEmailHistoryInfo")]
        public async Task<GetAllEmailHistoryResultDto> GetAllEmailHistoryInfo()
        {
            var listDto = await _context.GetAll();
            return new GetAllEmailHistoryResultDto()
            {
                // 剔除创建时间和删除状态
                ResultListDto = ModelBindingService.CopyModelList<EmailHistoryInfoDto, FH_EmailHistoryInfo>(listDto),
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据收件人账号得到所有邮件历史信息
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        [HttpGet("GetAllEmailHistoryInfoByRecipientId")]
        public async Task<GetAllEmailHistoryResultDto> GetAllEmailHistoryInfoByRecipientId(string recipientId)
        {
            var listDto = await _context.GetByWhere(e => e.RecipientId.Equals(recipientId));
            return new GetAllEmailHistoryResultDto()
            {
                ResultListDto = ModelBindingService.CopyModelList<EmailHistoryInfoDto, FH_EmailHistoryInfo>(listDto),
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据收件人账号得到最后一个邮件历史信息
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        [HttpGet("GetLastEmailHistoryInfoByRecipientId")]
        public async Task<GetLastEmailHistoryInfoByRecipientIdResultDto> GetLastEmailHistoryInfoByRecipientId(string recipientId)
        {
            var emailhistoryInfo = (await _context
                .GetByWhere(e => e.RecipientId.Equals(recipientId), true, e => e.CreateTime, SqlSugar.OrderByType.Desc)).First();
            var result = new GetLastEmailHistoryInfoByRecipientIdResultDto();
            ModelBindingService.CopyModel(result.EmailHistoryInfo, emailhistoryInfo);
            // 判断是否为空
            if (emailhistoryInfo == null)
            {
                result.Success = false;
                result.ResultInfo = string.Format("【{0}】账号暂无邮件历史信息，请检查账号是否正确！如账号准确无误，请联系管理员。", recipientId);
                return result;
            }
            // 判断是否过期（10分钟）
            if (emailhistoryInfo.CreateTime.AddMinutes(10) < DateTime.Now)
            {
                result.Success = false;
                result.ResultInfo = string.Format("【{0}】账号验证码已过期，请重新发送！", recipientId);
                result.EmailHistoryInfo = null;
                return result;
            }
            return result;
        }

        /// <summary>
        /// 根据收件人账号得到最后一个邮件的验证码信息
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("GetLastEmailHistoryCodeInfoByRecipientId")]
        public async Task<GetLastEmailHistoryCodeInfoByRecipientIdResultDto> GetLastEmailHistoryCodeInfoByRecipientId(string recipientId)
        {
            var emailhistoryInfo = (await _context
                .GetByWhere(e => e.RecipientId.Equals(recipientId), true, e => e.CreateTime, SqlSugar.OrderByType.Desc)).First();
            var result = new GetLastEmailHistoryCodeInfoByRecipientIdResultDto();
            // 判断是否为空
            if (emailhistoryInfo == null)
            {
                result.Success = false;
                result.ResultInfo = string.Format("【{0}】账号暂无邮件历史信息，请检查账号是否正确！如账号准确无误，请联系管理员。", recipientId);
                return result;
            }
            ModelBindingService.CopyModel(result, emailhistoryInfo);
            // 判断是否过期（10分钟）
            if (emailhistoryInfo.CreateTime.AddMinutes(10) < DateTime.Now)
            {
                return result = new GetLastEmailHistoryCodeInfoByRecipientIdResultDto
                {
                    RecipientId = recipientId,
                    Success = false,
                    ResultInfo = string.Format("【{0}】账号验证码已过期，请重新发送！", recipientId)
                };
            }
            return result;
        }

        /// <summary>
        /// 添加邮件历史信息
        /// </summary>
        /// <param name="createEmailHistoryInfoDto">添加邮件历史信息类</param>
        /// <param name="isSendEmail">是否发送邮件，默认为发送</param>
        /// <returns></returns>
        [HttpPost("CreateEmailHistoryInfo")]
        public async Task<ResultDto> CreateEmailHistoryInfo(createEmailHistoryInfoDto createEmailHistoryInfoDto, bool? isSendEmail = true)
        {
            // 检测邮箱账号为否为QQ邮箱，并且是否正确
            string expression = AppConfigurtaionService.Configuration["EmailServicesStrings:EmailExpression"]; // 拿到配置文件中的正则表达式
            if (!Regex.IsMatch(createEmailHistoryInfoDto.RecipientId, expression, RegexOptions.Compiled))
            {
                // 请输入正确的QQ邮箱账号
                throw new Exception("Please enter the correct QQ email account.");
            }
            FH_EmailHistoryInfo emailHistory = new FH_EmailHistoryInfo()
            {
                RecipientId = createEmailHistoryInfoDto.RecipientId,
                EmailBody = createEmailHistoryInfoDto.EmailBody
            };
            // 发送QQ邮件
            if (isSendEmail.Value)
            {
                emailHistory.EmailBody = _emailServices.SendRandomCodeQQEmail(emailHistory.RecipientId).RecipientBody;
            }
            return new ResultDto() { Success = await _context.Add(emailHistory) };
        }

        /// <summary>
        /// 修改邮件历史信息
        /// </summary>
        /// <param name="updateEmailHistoryInfoDto">修改件历史信息类</param>
        /// <returns></returns>
        [HttpPut("UpdateEmailHistoryInfo")]
        public async Task<ResultDto> UpdateEmailHistoryInfo(UpdateEmailHistoryInfoDto updateEmailHistoryInfoDto)
        {
            return new ResultDto()
            {
                Success = await _context.Update(
                    new FH_EmailHistoryInfo()
                    {
                        EHID = updateEmailHistoryInfoDto.EHID,
                        EmailBody = updateEmailHistoryInfoDto.EmailBody
                    })
            };
        }

        /// <summary>
        /// 删除邮件历史信息
        /// </summary>
        /// <param name="ehID">ID</param>
        /// <returns></returns>
        [HttpDelete("DeleteEmailHistoryInfo")]
        public async Task<ResultDto> DeleteEmailHistoryInfo(int ehID)
        {
            return new ResultDto()
            {
                Success = await _context.Update(
                    new FH_EmailHistoryInfo()
                    {
                        EHID = ehID,
                        IsDeleted = 1
                    })
            };
        }

        /// <summary>
        /// 彻底删除邮件历史信息
        /// </summary>
        /// <param name="ehID">ID</param>
        /// <returns></returns>
        [HttpDelete("RemoveEmailHistoryInfo")]
        public async Task<ResultDto> RemoveEmailHistoryInfo(int ehID)
        {
            return new ResultDto()
            {
                Success = await _context.Delete(ehID)
            };
        }
    }
}