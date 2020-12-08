using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.Extend {
    /// <summary>
    /// 字符串扩展
    /// </summary>
    public static class StingExtend {

        /// <summary>
        /// 字符串转int32,默认返回0
        /// </summary>
        /// <param name="val"></param>
        /// <returns>0</returns>
        public static int ToInt(this string val) {
            int newVal = 0;
            try {
                newVal = Convert.ToInt32(val);
            }
            catch (Exception) {

            }
            return newVal;
        }

        /// <summary>
        /// 字符串转int32，默认返回null
        /// </summary>
        /// <param name="val"></param>
        /// <returns>null</returns>
        public static int? ToIntNull(this string val) {
            int? newVal = 0;
            try {
                newVal = Convert.ToInt32(val);
            }
            catch (Exception) {
                newVal = null;
            }
            return newVal;
        }
    }
}
