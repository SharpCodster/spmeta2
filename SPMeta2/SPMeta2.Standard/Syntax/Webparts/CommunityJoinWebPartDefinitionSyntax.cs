using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{

    [Serializable]
    [DataContract]
    public class CommunityJoinWebPartModelNode : WebPartModelNode
    {

    }

    public static class CommunityJoinWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddCommunityJoinWebPart<TModelNode>(this TModelNode model, CommunityJoinWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddCommunityJoinWebPart(model, definition, null);
        }

        public static TModelNode AddCommunityJoinWebPart<TModelNode>(this TModelNode model, CommunityJoinWebPartDefinition definition,
            Action<CommunityJoinWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddCommunityJoinWebParts<TModelNode>(this TModelNode model, IEnumerable<CommunityJoinWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
