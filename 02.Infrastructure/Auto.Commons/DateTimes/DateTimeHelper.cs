using System;

namespace Auto.Commons.DateTimes {
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
        /// 将 DateTime时间格式 转换为Unix时间戳格式  
        /// </summary>  
        /// <param name="time">时间</param>  
        /// <returns>long</returns>  
        public static long ConvertDateTimeToInt(DateTime time) {
            System.DateTime Time = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long TimeStamp = (time.Ticks - Time.Ticks) / 10000;   //除10000调整为13位     
            return TimeStamp;
        }
        /// <summary>  
        /// 将 Unix时间戳格式 转换为DateTime时间格式
        /// </summary>  
        /// <param name="time">时间</param>  
        /// <returns>long</returns>  
        public static DateTime ConvertDateTimeToInt(long time) {
            System.DateTime Time = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime dateTime = Time.AddMilliseconds(time);
            return dateTime;
        }
        /// <summary>
        /// 得到本周第一天(以星期天为第一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekFirstDaySun(DateTime datetime) {
            //星期天为第一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            int daydiff = (-1) * weeknow;

            //本周第一天
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }
        /// <summary>
        /// 得到本周第一天(以星期一为第一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekFirstDayMon(DateTime datetime) {
            //星期一为第一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }
        /// <summary>
        /// 得到本周最后一天(以星期六为最后一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekLastDaySat(DateTime datetime) {
            //星期六为最后一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            int daydiff = (7 - weeknow) - 1;

            //本周最后一天
            string LastDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(LastDay);
        }
        /// <summary>
        /// 得到本周最后一天(以星期天为最后一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekLastDaySun(DateTime datetime) {
            //星期天为最后一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            weeknow = (weeknow == 0 ? 7 : weeknow);
            int daydiff = (7 - weeknow);

            //本周最后一天
            string LastDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(LastDay);
        }
        /// <summary>
        /// 获取开始时间
        /// </summary>
        /// <param name="type"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime GetTimeStartByType(DataTimeType type, DateTime time) {
            switch (type) {
                case DataTimeType.Week:
                    return time.AddDays(-(int)time.DayOfWeek + 1);
                case DataTimeType.Month:
                    return time.AddDays(-(int)time.Day + 1);
                case DataTimeType.Season:
                    var time1 = time.AddMonths(0 - ((time.Month - 1) % 3));
                    return time1.AddDays(-time1.Day + 1);
                case DataTimeType.Year:
                    return time.AddDays(-(int)time.DayOfYear + 1);
                default:
                    return time.AddDays(-(int)time.DayOfWeek + 1);
                    //return null;
            }
        }
        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="DataTimeType">Week、Month、Season、Year</param>
        /// <param name="now"></param>
        /// <returns></returns>
        public static DateTime GetTimeEndByType(DataTimeType type, DateTime now) {
            switch (type) {
                case DataTimeType.Week:
                    return now.AddDays(7 - (int)now.DayOfWeek);
                case DataTimeType.Month:
                    return now.AddMonths(1).AddDays(-now.AddMonths(1).Day + 1).AddDays(-1);
                case DataTimeType.Season:
                    var time = now.AddMonths((3 - ((now.Month - 1) % 3) - 1));
                    return time.AddMonths(1).AddDays(-time.AddMonths(1).Day + 1).AddDays(-1);
                case DataTimeType.Year:
                    var time2 = now.AddYears(1);
                    return time2.AddDays(-time2.DayOfYear);
                default:
                    return now.AddDays(7 - (int)now.DayOfWeek);
            }
        }
    }
    public enum DataTimeType {
        Week,
        Month,
        Season,
        Year
    }
}
