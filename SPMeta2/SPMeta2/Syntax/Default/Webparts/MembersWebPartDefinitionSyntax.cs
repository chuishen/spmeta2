using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class MembersWebPartModelNode : WebPartModelNode
    {

    }

    public static class MembersWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddMembersWebPart<TModelNode>(this TModelNode model, MembersWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddMembersWebPart(model, definition, null);
        }

        public static TModelNode AddMembersWebPart<TModelNode>(this TModelNode model, MembersWebPartDefinition definition,
            Action<MembersWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddMembersWebParts<TModelNode>(this TModelNode model, IEnumerable<MembersWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
