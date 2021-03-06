using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class SPTimelineWebPartModelNode : WebPartModelNode
    {

    }

    public static class SPTimelineWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddSPTimelineWebPart<TModelNode>(this TModelNode model, SPTimelineWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddSPTimelineWebPart(model, definition, null);
        }

        public static TModelNode AddSPTimelineWebPart<TModelNode>(this TModelNode model, SPTimelineWebPartDefinition definition,
            Action<SPTimelineWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddSPTimelineWebParts<TModelNode>(this TModelNode model, IEnumerable<SPTimelineWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
