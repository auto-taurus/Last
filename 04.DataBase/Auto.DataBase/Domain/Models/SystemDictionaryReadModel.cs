using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class SystemDictionaryReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int DictionaryId { get; set; }

        public string Keys { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
