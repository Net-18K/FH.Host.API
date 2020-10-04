using System;

namespace FH.Host.API.Infrastructure.Log4Net
{
    /// <summary>
    /// Log4Net帮助类
    /// </summary>
    public static class Log4NetHelper
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 写入Debug信息
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(object message)
        {
            log.Debug(message);
        }

        /// <summary>
        /// 写入带有异常信息的Debug
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Debug(object message, Exception exception)
        {
            log.Debug(message, exception);
        }

        /// <summary>
        /// 写入Info信息
        /// </summary>
        /// <param name="message"></param>
        public static void Info(object message)
        {
            log.Info(message);
        }

        /// <summary>
        /// 写入带有异常信息的Info
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Info(object message, Exception exception)
        {
            log.Info(message, exception);
        }

        /// <summary>
        /// 写入Warn信息
        /// </summary>
        /// <param name="message"></param>
        public static void Warn(object message)
        {
            log.Warn(message);
        }

        /// <summary>
        /// 写入带有异常信息的Warn
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Warn(object message, Exception exception)
        {
            log.Warn(message, exception);
        }

        /// <summary>
        /// 写入Error信息
        /// </summary>
        /// <param name="message"></param>
        public static void Error(object message)
        {
            log.Error(message);
        }

        /// <summary>
        /// 写入带有异常信息的Error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Error(object message, Exception exception)
        {
            log.Error(message, exception);
        }

        /// <summary>
        /// 写入Fatal信息
        /// </summary>
        /// <param name="message"></param>
        public static void Fatal(object message)
        {
            log.Fatal(message);
        }

        /// <summary>
        /// 写入带有异常信息的Fatal
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Fatal(object message, Exception exception)
        {
            log.Fatal(message, exception);
        }
    }
}