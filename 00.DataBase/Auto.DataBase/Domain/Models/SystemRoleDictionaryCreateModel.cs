using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class SystemRoleDictionaryCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string DictionaryKey { get; set; }

        public string DictionaryValue { get; set; }

        #endregion

    }
}
