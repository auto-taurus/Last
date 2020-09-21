using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemUsersInDictionary
        : EntityBase
    {
        public SystemUsersInDictionary()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public string DictionaryKey { get; set; }

        public string DictionaryValue { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemUsers UserSystemUsers { get; set; }

        #endregion

    }
}
