﻿using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.Definitions
{
    /// <summary>
    ///  Allows to attach field to the target list.
    /// </summary>
    /// 

    [SPObjectTypeAttribute(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPField", "Microsoft.SharePoint")]
    [SPObjectTypeAttribute(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.Field", "Microsoft.SharePoint.Client")]

    [RootHostAttribute(typeof(WebDefinition))]
    [ParentHostAttribute(typeof(ListDefinition))]

    [Serializable]
    public class ListFieldLinkDefinition : DefinitionBase
    {
        #region properties

        #region properties

        /// <summary>
        /// ID of the target field to be attached to content type.
        /// BuiltInFieldId class can be used to utilize out of the box SharePoint fields. 
        /// </summary>
        public Guid FieldId { get; set; }

        #endregion

        #endregion
    }
}