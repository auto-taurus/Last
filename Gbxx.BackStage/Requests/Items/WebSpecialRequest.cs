using Auto.Entities.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Requests.Items {
    public class WebSpecialRequest {
        public int SpecialId { get; set; }

        public int? SiteId { get; set; }

        public string SpecialCode { get; set; }

        public string Name { get; set; }

        public int? DisplayType { get; set; }

        public Byte[] Timestamp { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
    public static class WebSpecialRequestExts {
        public static WebSpecial ToEntity(this WebSpecialRequest request) {
            return new WebSpecial {
                SpecialId = request.SpecialId,
                Name = request.Name
            };
        }
    }
}
