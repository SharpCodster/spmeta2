﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPMeta2.CSOM.Standard.Config
{
    public class MetadataNavigationKeyFilterConfig
    {
         #region constructors
        public MetadataNavigationKeyFilterConfig()
        {

        }
        #endregion

        #region properties
        public Guid FieldId { get; set; }
        public string FieldType { get; set; }
        public string CachedName { get; set; }
        public string CachedDisplayName { get; set; }
        #endregion
    }
}
