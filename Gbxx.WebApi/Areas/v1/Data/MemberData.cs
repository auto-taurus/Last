using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    public class MemberData {

        public int MemberId { get; set; }

        public string NickName { get; set; }

        public string Name { get; set; }

        public int? Sex { get; set; }

        public string Phone { get; set; }

        public string Alipay { get; set; }

        public string Wechat { get; set; }

        public string Avatar { get; set; }

        public int? Beans { get; set; }

        public int? BeansTotals { get; set; }

    }
}
