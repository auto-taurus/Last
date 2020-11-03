using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class SystemUsersDictionaryCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public string DictionaryKey { get; set; }

        public string DictionaryValue { get; set; }

        #endregion

    }
}
