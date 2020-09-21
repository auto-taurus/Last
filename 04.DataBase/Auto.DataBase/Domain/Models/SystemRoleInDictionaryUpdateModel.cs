using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class SystemRoleInDictionaryUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string DictionaryKey { get; set; }

        public string DictionaryValue { get; set; }

        #endregion

    }
}
