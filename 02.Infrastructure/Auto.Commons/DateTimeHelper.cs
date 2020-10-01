using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Auto.Commons {
    public static class DateTimeHelper {
        /// <summary>
        /// 获取今天距离周一有多少天
        /// </summary>
        /// <returns></returns>
        public static int GetDays() {
            var day = System.DateTime.Now;
            var dayWeek = day.AddDays(1 - Convert.ToInt32(day.DayOfWeek.ToString("d")));  //本周周一
            return day.Subtract(dayWeek).Days;
        }
        /// <summary>
        /// 获取年份中第几周及当天至周一的天数
        /// 年，月，年份中第几周，当前周的天数，当前日期天
        /// </summary> 
        /// <returns></returns>
        public static Tuple<int, string, string, int, int> GetWeekAndDays(DateTime? dateTime = null) {
            //当前时间
            var day = dateTime.HasValue ? dateTime.Value : System.DateTime.Now;
            //获取当年第几周
            int week = System.Threading.Thread.CurrentThread.CurrentUICulture.Calendar.GetWeekOfYear(day, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            //获取今天距本周的天数
            var days = 0;
            var monday = day.AddDays(1 - Convert.ToInt32(day.DayOfWeek.ToString("d")));  //本周周一
            return new Tuple<int, string, string, int, int>(day.Year, day.Month.ToString("D2"), week.ToString("D2"), monday.Day, Convert.ToInt32(day.DayOfWeek.ToString("d")));
        }
        /// <summary>
        /// 获取月份及天数
        /// 年，月，月份的天数，当前日期天
        /// </summary>
        /// <returns></returns>
        public static Tuple<int, string, int, string> GetMonthAndDays(DateTime? dateTime = null) {
            //当前时间
            var day = dateTime.HasValue ? dateTime.Value : System.DateTime.Now;
            var month = day.Month;
            int days = System.Threading.Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInMonth(day.Year, month);
            return new Tuple<int, string, int, string>(day.Year, month.ToString("D2"), days, day.Day.ToString("D2"));
        }
        /// <summary>  
        /// 将 DateTime时间格式转换为Unix时间戳格式  
        /// </summary>  
        /// <param name="time">时间</param>  
        /// <returns>long</returns>  
        public static long ConvertDateTimeToInt(DateTime time) {
            System.DateTime Time = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long TimeStamp = (time.Ticks - Time.Ticks) / 10000;   //除10000调整为13位     
            return TimeStamp;
        }
        /// <summary>  
        /// 将Unix时间戳格式 转换为DateTime时间格式
        /// </summary>  
        /// <param name="time">时间</param>  
        /// <returns>long</returns>  
        public static DateTime ConvertDateTimeToInt(long time) {
            System.DateTime Time = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime dateTime = Time.AddMilliseconds(time);
            return dateTime;
        }
    }
}
