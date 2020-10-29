using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class SystemDictionaryUpdateModel
    {
        #region Generated Properties
        public int DictionaryId { get; set; }

        public string TypeKey { get; set; }

        public string DistKey { get; set; }

        public string DistName { get; set; }

        public string DistValue { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
