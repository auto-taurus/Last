using Newtonsoft.Json;
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

        /// <summary>
        /// 字符串转decimal，默认返回null
        /// </summary>
        /// <param name="val"></param>
        /// <returns>null</returns>
        public static decimal? ToDecimal(this string val) {
            decimal? newVal = 0;
            try {
                newVal = Convert.ToDecimal(val);
            }
            catch (Exception) {
                newVal = null;
            }
            return newVal;
        }

        /// <summary>
        /// 字符串转object,默认返回null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string val) {
            try {
                return JsonConvert.DeserializeObject<T>(val);
            }
            catch (Exception) {
                return default(T);
            }
        }


        /// <summary>
        /// 字符串转List，默认返回null
        /// 调用：List<int> intList = str.ToList<int>(',', s => int.Parse(s));
        /// </summary>
        /// <param name="str"></param>
        /// <returns>null</returns>
        public static List<T> ToList<T>(this string str, char split, Converter<string, T> convertHandler) {
            try {
                if (string.IsNullOrEmpty(str)) {
                    return new List<T>();
                }
                else {
                    string[] arr = str.Split(split);
                    T[] Tarr = Array.ConvertAll(arr, convertHandler);
                    return new List<T>(Tarr);
                }
            }
            catch (Exception) {
                return null;
            }
        }
    }
}
