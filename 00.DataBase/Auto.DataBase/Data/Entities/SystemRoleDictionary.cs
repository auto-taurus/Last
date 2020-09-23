using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemRoleDictionary
        : EntityBase
    {
        public SystemRoleDictionary()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string DictionaryKey { get; set; }

        public string DictionaryValue { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemRole SystemRole { get; set; }

        #endregion

    }
}
