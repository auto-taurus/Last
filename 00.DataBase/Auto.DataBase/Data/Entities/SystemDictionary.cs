using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemDictionary
        : IBaseEntity
    {
        public SystemDictionary()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DictionaryId { get; set; }

        public string Keys { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
