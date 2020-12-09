using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Auto.Commons {
    //************************************************************************
    /// <summary>
    /// Err Log输出Class
    /// </summary>
    //************************************************************************
    public class CMLogger
    {
        #region Field

        private static CMLogger s_cmLogger = null;
        private static readonly object padlock = new object();
        //Log输出级别
        private static int m_logLevel = 0;
        //Log文件路径
        private static string m_logFilePath = "";
        //FlushIntervalMSecs
        private static int m_logFlushIntervalMSecs;

        private static Mutex mu = new Mutex(false);

        private static string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogInfo");

        private static int logFlushIntervalMSecs = 10000;

        //刷新线程
        private Thread writeThread;
        private StringBuilder sb;
        private bool isActive = false;
        //输出级别枚举
        public enum LogLevelEnum
        {
            DEBUG = 0, Info, Warn, Error
        }

        #endregion

        #region 构造函数
        //************************************************************************
        /// <summary>
        /// CMLogger
        /// </summary>
        //************************************************************************
        private CMLogger()
        {
        }
        #endregion

        #region public method
        //************************************************************************
        /// <summary>
        /// CMLogger 的class instance取得
        /// </summary>
        //************************************************************************
        public static CMLogger GetInstance()
        {
            //单例模式
            if (s_cmLogger == null)
            {
                lock (padlock)
                {
                    if (s_cmLogger == null)
                    {
                        s_cmLogger = new CMLogger();
                        //级别取得
                        m_logLevel = 0;
                        //文件路径取得
                        m_logFilePath = logFilePath;

                        //确保路径最后没有"\"
                        if (m_logFilePath.Substring(m_logFilePath.Length - 2, 2) == "\\")
                            m_logFilePath = m_logFilePath.Substring(0, m_logFilePath.Length - 2);

                        // Determine whether the directory exists.
                        if (!Directory.Exists(m_logFilePath))
                        {
                            Directory.CreateDirectory(m_logFilePath);
                            foreach (string e in Enum.GetNames(typeof(LogLevelEnum)))
                            {
                                Directory.CreateDirectory(m_logFilePath + "\\" + e);
                            }
                        }
                        else
                        {
                            foreach (string e in Enum.GetNames(typeof(LogLevelEnum)))
                            {
                                if (!Directory.Exists(m_logFilePath + "\\" + e))
                                {
                                    Directory.CreateDirectory(m_logFilePath + "\\" + e);
                                }
                            }
                        }

                        if (logFlushIntervalMSecs > 0)
                        {
                            m_logFlushIntervalMSecs = logFlushIntervalMSecs;
                        }
                    }
                }
            }
            return s_cmLogger;
        }

        private void CreateDirectory(string m_logFilePath)
        {
            if (!Directory.Exists(m_logFilePath))
            {
                Directory.CreateDirectory(m_logFilePath);
                foreach (string e in Enum.GetNames(typeof(LogLevelEnum)))
                {
                    Directory.CreateDirectory(m_logFilePath + "\\" + e);
                }
            }
            else
            {
                foreach (string e in Enum.GetNames(typeof(LogLevelEnum)))
                {
                    if (!Directory.Exists(m_logFilePath + "\\" + e))
                    {
                        Directory.CreateDirectory(m_logFilePath + "\\" + e);
                    }
                }
            }
        }

        //************************************************************************
        /// <summary>
        /// Debug Log输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        public void WriteDebugLog(string argFqcn, string argMethodName, string argMessage)
        {
            WriteLogFile(LogLevelEnum.DEBUG, argFqcn, argMethodName, argMessage, null);
        }

        //************************************************************************
        /// <summary>
        /// Debug Log输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        public void WriteDebugLog(string argFqcn, string argMethodName, string argMessage, object argDataObject)
        {
            WriteDataLog(LogLevelEnum.DEBUG, argFqcn, argMethodName, argMessage, argDataObject);
        }

        //************************************************************************
        /// <summary>
        /// 信息LOG输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        public void WriteInfoLog(string argFqcn, string argMethodName, string argMessage)
        {
            WriteLogFile(LogLevelEnum.Info, argFqcn, argMethodName, argMessage, null);
        }

        //************************************************************************
        /// <summary>
        /// 信息LOG输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argDataObject">dataobject</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        public void WriteInfoLog(string argFqcn, string argMethodName, string argMessage, object argDataObject)
        {
            WriteDataLog(LogLevelEnum.Info, argFqcn, argMethodName, argMessage, argDataObject);
        }

        //************************************************************************
        /// <summary>
        /// 警告LOG输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// </summary>
        //************************************************************************
        public void WriteWarnLog(string argFqcn, string argMethodName, string argMessage)
        {
            WriteLogFile(LogLevelEnum.Warn, argFqcn, argMethodName, argMessage, null);
        }

        //************************************************************************
        /// <summary>
        /// 错误LOG输出
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argEx">错误信息</param>
        /// <param name="argUserID">用户名</param>
        /// </summary>
        //************************************************************************
        public void WriteErrLog(string argFqcn, string argMethodName, string argMessage, Exception argEx)
        {
            WriteLogFile(LogLevelEnum.Error, argFqcn, argMethodName, argMessage, argEx);
        }

        //************************************************************************
        /// <summary>
        /// Data Class内容LOG输出
        /// <param name="argLoglevel">LOG级别</param>
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argDataName">Data名</param>
        /// <param name="argDataObject">dataobject</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        private void WriteDataLog(LogLevelEnum argLoglevel, string argFqcn, string argMethodName, string argDataName, object argDataObject)
        {
            string strMessage = "";

            // Data Object为null时、NULL输出返回
            if (argDataObject == null)
            {
                strMessage = argDataName + "\t" + "NULL";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);
                return;
            }

            #region 反射写出数据
            // object的类型取得
            Type classType = argDataObject.GetType();

            // 基本型时
            if (isBaseType(classType))
            {
                // 基本型时
                strMessage = argDataName + "\t" + "[" + classType.Name + "]";
                strMessage += "\t" + "[" + argDataObject.ToString() + "]";

                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);
                return;
            }

            // Array时
            if (classType.IsArray)
            {
                long[] indexArray = null; ;

                int intArrayLength = ((Array)argDataObject).Length;
                for (int index = 0; index < intArrayLength; index++)
                {
                    indexArray = getArrayMember((Array)argDataObject, index);
                    object arrayObj = ((Array)argDataObject).GetValue(indexArray);

                    // Array的名称取得
                    string objName = argDataName + "[" + indexArray[0].ToString();
                    for (int i = 1; i < indexArray.Length; i++)
                    {
                        objName += "," + indexArray[i].ToString();
                    }
                    objName += "]";

                    // Array的名称为NUll时
                    if (arrayObj == null)
                    {
                        strMessage = objName + "\t" + "[" + argDataObject.GetType().GetElementType().Name + "]";
                        strMessage += "\t" + "NULL";
                        WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);
                    }
                    else
                    {
                        WriteDataLog(argLoglevel, argFqcn, argMethodName, objName, arrayObj);
                    }
                }
                return;
            }

            string strSpace = "";
            for (int temp = 0; temp < argDataName.Length; temp++)
            {
                if (argDataName.Substring(temp, 1) == " ")
                {
                    strSpace += " ";
                }
                else if (argDataName.Substring(temp, 1) == "　")
                {
                    strSpace += " ";
                }
                else
                {
                    break;
                }
            }
            strSpace += "   ";

            // Hashtable 时
            if (classType.Name == "Hashtable")
            {
                Hashtable ht = (Hashtable)argDataObject;
                System.Collections.IEnumerator keyEnum = ht.Keys.GetEnumerator();
                int count = ht.Count;
                keyEnum.Reset();
                strMessage = argDataName + "----------------------";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                for (int i = 0; i < count; i++)
                {
                    keyEnum.MoveNext();
                    object hashKey = keyEnum.Current;	// Key
                    object hashValue = ht[hashKey];	// Value
                    WriteDataLog(argLoglevel, argFqcn, argMethodName, strSpace + hashKey.ToString(), hashValue);
                }
                return;
            }

            // ArrayList时
            if (classType.Name == "ArrayList")
            {
                ArrayList at = (ArrayList)argDataObject;
                int count = at.Count;
                strMessage = argDataName + "----------------------";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                for (int i = 0; i < count; i++)
                {
                    WriteDataLog(argLoglevel, argFqcn, argMethodName, strSpace + "[" + i.ToString() + "]", at[i].ToString());
                }
                return;
            }

            // DataSet时
            if (classType.Name == "DataSet" || classType.BaseType.Name == "DataSet")
            {
                strMessage = argDataName + "----------------------";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                foreach (DataTable myDataTable in ((DataSet)argDataObject).Tables)
                {
                    strMessage = strSpace + "Table名：" + "\t" + "[" + myDataTable.TableName + "]";
                    WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                    int intCurrentRow = 0;
                    foreach (DataRow myRow in myDataTable.Rows)
                    {
                        foreach (DataColumn myColumn in myDataTable.Columns)
                        {
                            WriteDataLog(argLoglevel, argFqcn, argMethodName, strSpace + myColumn.ColumnName + "[" + intCurrentRow.ToString() + "]", myRow[myColumn]);
                        }
                        intCurrentRow++;
                    }
                }
                return;
            }

            // DataTable时
            if (classType.Name == "DataTable" || classType.BaseType.Name == "DataTable")
            {
                strMessage = argDataName + "----------------------";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                DataTable myDataTable = (DataTable)argDataObject;

                strMessage = strSpace + "Table名：" + "\t" + "[" + myDataTable.TableName + "]";
                WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

                int intCurrentRow = 0;
                foreach (DataRow myRow in myDataTable.Rows)
                {
                    foreach (DataColumn myColumn in myDataTable.Columns)
                    {
                        WriteDataLog(argLoglevel, argFqcn, argMethodName, strSpace + myColumn.ColumnName + "[" + intCurrentRow.ToString() + "]", myRow[myColumn]);
                    }
                    intCurrentRow++;
                }
                return;
            }

            // 基本型、array、Hashtable以外时
            strMessage = argDataName + "----------------------";
            WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);

            System.Reflection.PropertyInfo[] pi = classType.GetProperties();
            System.Reflection.MemberInfo[] classMembInfo = classType.GetMembers();
            System.Reflection.FieldInfo[] classFieldInfo = classType.GetFields();
            System.Reflection.ConstructorInfo[] classConstInfo = classType.GetConstructors();
            // 各属性输出
            foreach (System.Reflection.PropertyInfo tpi in pi)
            {
                if (tpi.GetValue(argDataObject, null) == null)
                {
                    strMessage = strSpace + tpi.Name + "\t" + "[" + tpi.PropertyType.Name + "]";
                    strMessage += "\t" + "NULL";
                    WriteLogFile(argLoglevel, argFqcn, argMethodName, strMessage, null);
                }
                else
                {
                    WriteDataLog(argLoglevel, argFqcn, argMethodName, strSpace + tpi.Name, tpi.GetValue(argDataObject, null));
                }
            }
            #endregion
        }

        //************************************************************************
        /// <summary>
        /// 基本型判断
        /// </summary>
        /// <param name="argType">型</param>
        /// <return>基本型时TRUE返回、以外时FALSE返回</return>
        //************************************************************************
        private bool isBaseType(System.Type argType)
        {
            if (argType.Name == "Boolean" ||
                argType.Name == "Byte" ||
                argType.Name == "Char" ||
                argType.Name == "DateTime" ||
                argType.Name == "Decimal" ||
                argType.Name == "Double" ||
                argType.Name == "Int16" ||
                argType.Name == "Int32" ||
                argType.Name == "Int64" ||
                argType.Name == "Object" ||
                argType.Name == "SByte" ||
                argType.Name == "Single" ||
                argType.Name == "String" ||
                argType.Name == "UInt16" ||
                argType.Name == "UInt32" ||
                argType.Name == "UInt64")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //************************************************************************
        /// <summary>
        /// Array中取得指定要素的位置
        /// </summary>
        /// <param name="argArray">Array变量</param>
        /// <param name="index">要素的顺序</param>
        /// <return>指定要素的位置</return>
        /// <example>
        /// 例：aryTest[2,3,3]中第5的要素为aryTest[0,1,2]。
        /// argReturn[3] = {0,1,2}的Array返回
        /// </example>
        //************************************************************************
        private long[] getArrayMember(Array argArray, int argIndex)
        {
            long[] aryResult = null;

            // 指定Array为空时
            if (argArray == null)
            {
                return null;
            }
            // index范围指定错误
            if ((argIndex >= argArray.Length) || (argIndex < 0))
            {
                return null;
            }

            //  Array的下一个元素取得
            int intDimension = argArray.Rank;
            aryResult = new long[intDimension];

            for (int i = intDimension - 1; i >= 0; i--)
            {
                int intLength = argArray.GetLength(i);
                int n = argIndex % intLength;
                argIndex = (int)(argIndex / intLength);

                aryResult[i] = argArray.GetLowerBound(i) + n;

                if (argIndex == 0) break;
            }

            return aryResult;
        }

        private void Flush()
        {
            while (true)
            {
                if (sb != null && sb.Length > 0)
                {
                    lock (sb)
                    {

                        string strSysTime = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF");
                        string processName = Process.GetCurrentProcess().Id.ToString();
                        string logFullPath = m_logFilePath + "\\" + LogLevelEnum.Info.ToString() + "\\" + strSysTime.Substring(0, 13).Trim() + processName + ".log";

                        CreateDirectory(m_logFilePath);

                        if (!File.Exists(logFullPath))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(logFullPath))
                            {
                                sw.Write(sb.ToString());
                                sw.Close();
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(logFullPath))
                            {
                                sw.Write(sb.ToString());
                                sw.Close();
                            }
                        }

                        sb.Remove(0, sb.Length);
                    }
                }

                Thread.Sleep(m_logFlushIntervalMSecs);
            }
        }

        //************************************************************************
        /// <summary>
        /// LOG文件输出
        /// <param name="argLevel">错误级别</param>
        /// <param name="argFqcn">Class名</param>
        /// <param name="argMethodName">method名</param>
        /// <param name="argMessage">msg</param>
        /// <param name="argEx">异常类(有异常时)</param>
        /// <param name="argUserID">用户名</param>
        /// <param name="argIpAddress">IPAddress</param>
        /// </summary>
        //************************************************************************
        private void WriteLogFile(LogLevelEnum argLevel, string argFqcn, string argMethodName, string argMessage, Exception argEx)
        {
            if (((int)argLevel) < m_logLevel)
                return;

            if ((m_logFlushIntervalMSecs > 0) && (!isActive))
            {
                writeThread = new Thread(Flush);
                writeThread.IsBackground = true;
                writeThread.Start();

                sb = new StringBuilder();

                isActive = true;
            }

            if (m_logFlushIntervalMSecs > 0 && ((int)argLevel) == 1
                && sb != null && sb.Length < int.MaxValue)
            {
                #region 第二种模式
                lock (sb)
                {
                    try
                    {
                        sb.AppendFormat("{0}\t{1}\t{2}\r\n", DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF"), argMethodName, argMessage);
                        if (argEx != null) sb.AppendLine(argEx.ToString());
                    }
                    catch { }
                }
                #endregion
            }
            else
            {
                #region 第一种模式
                try
                {

                    CMLogger.mu.WaitOne();

                    //if (String.IsNullOrEmpty(argIpAddress))
                    //{
                    //    argIpAddress = CMUtility.GetUserIp();
                    //}

                    string strSysTime = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF").Trim();
                    string processName = Process.GetCurrentProcess().Id.ToString();
                    string logFullPath = m_logFilePath + "\\" + argLevel.ToString() + "\\" + strSysTime.Substring(0, 13) + processName + ".log";

                    CreateDirectory(m_logFilePath);

                    //写字符串构成
                    //string logstr = strSysTime + "\t"
                    //              //+ (String.IsNullOrEmpty(argIpAddress) ? "\t" : CMUtility.GetUserIp() + "\t")
                    //              + (argFqcn + "(" + argMethodName + ")\t")
                    //              + (String.IsNullOrEmpty(argMessage) ? "\t" : argMessage + "\t")
                    //              + (argEx == null ? "\t" : argEx.Message + argEx.StackTrace + "\t");

                    if (!File.Exists(logFullPath))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(logFullPath))
                        {
                            sw.WriteLine("{0}\t{1}\t{2}", DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF"), argMethodName, argMessage);
                            if (argEx != null) sw.WriteLine(argEx.ToString());
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(logFullPath))
                        {
                            sw.WriteLine("{0}\t{1}\t{2}", DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF"), argMethodName, argMessage);
                            if (argEx != null) sw.WriteLine(argEx.ToString());
                            sw.Close();
                        }
                    }
                }
                catch
                {
                    //throw ex;
                }
                finally
                {
                    CMLogger.mu.ReleaseMutex();
                }
                #endregion
            }
        }
        #endregion

        ~CMLogger()
        {
            if (sb != null && sb.Length > 0)
            {
                lock (sb)
                {

                    string strSysTime = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.FFF").Trim();
                    string processName = Process.GetCurrentProcess().Id.ToString();
                    string logFullPath = m_logFilePath + "\\" + LogLevelEnum.Info.ToString() + "\\" + strSysTime.Substring(0, 13).Trim() + processName + ".log";

                    CreateDirectory(m_logFilePath);

                    if (!File.Exists(logFullPath))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(logFullPath))
                        {
                            sw.Write(sb.ToString());
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(logFullPath))
                        {
                            sw.Write(sb.ToString());
                            sw.Close();
                        }
                    }

                    sb.Remove(0, sb.Length);
                }
            }
        }

    }
}