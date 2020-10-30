using Gbxx.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    public class CommentGet : PagerBase {
        public int MemberId { get; set; }
    }
}
