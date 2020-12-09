using System;
using System.Configuration;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime;
using System.Reflection;
using System.Xml;
using System.Timers;

namespace Auto.Commons {
    /// <summary>
    /// 新日志模块类
    /// </summary>
    /// <remarks>
    /// 在并发比较高的服务站点建议使用本类完成, 日志记录到当前服务站点 Loginfo 目录下
    /// 默认不需要任何配置, 自定义配置请查看:
    ///     Config.LogOutLevel
    ///     Config.LogFilePath
    ///     Config.LogFlushIntervalMSecs
    /// </remarks>
    public static class LogHelper
    {
        #region WriteErrLog
        /// <summary>
        /// WriteErrLog
        /// </summary>
        /// <param name="e"></param>
        [Obsolete("请使用 LogError 方法")]
        public static void LogException(Exception e)
        {
            CMLogger.GetInstance().WriteErrLog(null, null, null, e);
        }
        /// <summary>
        /// WriteErrLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogError(string msg)
        {
            CMLogger.GetInstance().WriteErrLog(null, null, msg, null);
        }
        /// <summary>
        /// WriteErrLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogError(string format, params object[] para)
        {
            LogError(string.Format(format, para));
        }
        #endregion

        #region WriteDebugLog
        /// <summary>
        /// WriteDebugLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogDebug(string msg)
        {
            CMLogger.GetInstance().WriteDebugLog(null, null, msg);
        }
        /// <summary>
        /// WriteDebugLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogDebug(string format, params object[] para)
        {
            LogDebug(string.Format(format, para));
        }
        #endregion

        #region WriteSingleLine
        /// <summary>
        /// WriteWarnLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogWarn(string msg)
        {
            CMLogger.GetInstance().WriteWarnLog(null, null, msg);
        }
        /// <summary>
        /// WriteWarnLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogWarn(string format, params object[] para)
        {
            LogWarn(string.Format(format, para));
        }
        /// <summary>
        /// WriteWarnLog
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteSingleLine(string msg)
        {
            LogWarn(msg);
        }
        #endregion

        #region WriteInfoLog
        /// <summary>
        /// WriteInfoLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogInfo(string msg)
        {
            CMLogger.GetInstance().WriteInfoLog(null, null, msg);
        }
        /// <summary>
        /// WriteInfoLog
        /// </summary>
        /// <param name="msg"></param>
        public static void LogInfo(string format, params object[] para)
        {
            LogInfo(string.Format(format, para));
        }
        /// <summary>
        /// WriteInfoLog
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteLine(string msg)
        {
            LogInfo(msg);
        }
        /// <summary>
        /// WriteInfoLog
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="para"></param>
        public static void WriteFormat(string format, params object[] para)
        {
            LogInfo(format, para);
        }
        #endregion
    }
}
