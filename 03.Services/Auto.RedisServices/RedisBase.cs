using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.RedisServices {
    public class RedisBase {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        protected Tuple<string, int, int> GetDayAndPage(DateTime? dt, int? pageIndex, int? pageSize) {
            var day = dt.HasValue ? dt.Value.ToString("yyyyMMdd") : System.DateTime.Now.ToString("yyyyMMdd");

            if (!pageIndex.HasValue) pageIndex = 1;
            if (!pageSize.HasValue) pageSize = 10;

            pageIndex = pageSize.Value * (pageIndex.Value - 1);
            pageSize = pageIndex + (pageSize - 1);
            return new Tuple<string, int, int>(day, pageIndex.Value, pageSize.Value);
        }
    }
}
