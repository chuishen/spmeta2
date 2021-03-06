using System;
using SPMeta2.Containers.Services.Base;
using SPMeta2.Definitions;
using SPMeta2.Standard.Definitions.Webparts;

namespace SPMeta2.Containers.Standard.DefinitionGenerators.Webparts
{
    public class AdvancedSearchBoxDefinitionGenerator : TypedDefinitionGeneratorServiceBase<AdvancedSearchBoxDefinition>
    {
        public override DefinitionBase GenerateRandomDefinition(Action<DefinitionBase> action)
        {
            return WithEmptyDefinition(def =>
            {
                def.Id = Rnd.String();
                def.Title = Rnd.String();

                def.ZoneId = "FullPage";
                def.ZoneIndex = Rnd.Int(100);

                def.AndQueryTextBoxLabelText = Rnd.String();
                def.DisplayGroup = Rnd.String();
                def.LanguagesLabelText = Rnd.String();
                def.NotQueryTextBoxLabelText = Rnd.String();
                def.OrQueryTextBoxLabelText = Rnd.String();
                def.PhraseQueryTextBoxLabelText = Rnd.String();

                // TODO
                //def.AdvancedSearchBoxProperties = Rnd.String();
                def.PropertiesSectionLabelText = Rnd.String();
                def.ResultTypeLabelText = Rnd.String();
                def.ScopeLabelText = Rnd.String();
                def.ScopeSectionLabelText = Rnd.String();
                def.SearchResultPageURL = Rnd.String();

                def.ShowAndQueryTextBox = Rnd.Bool();
                def.ShowLanguageOptions = Rnd.Bool();
                def.ShowNotQueryTextBox = Rnd.Bool();
                def.ShowOrQueryTextBox = Rnd.Bool();
                def.ShowPhraseQueryTextBox = Rnd.Bool();
                def.ShowPropertiesSection = Rnd.Bool();
                def.ShowResultTypePicker = Rnd.Bool();
                def.ShowScopes = Rnd.Bool();

                def.TextQuerySectionLabelText = Rnd.String();
            });
        }
    }
}
