﻿using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Containers;
using SPMeta2.Containers.Extensions;
using SPMeta2.Containers.Services;
using SPMeta2.Containers.Standard;
using SPMeta2.CSOM;
using SPMeta2.CSOM.DefaultSyntax;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Regression.Tests.Definitions;
using SPMeta2.Regression.Tests.Impl.Scenarios.Base;
using SPMeta2.Standard.Definitions;
using SPMeta2.Syntax.Default;
using SPMeta2.Syntax.Default.Modern;
using SPMeta2.Exceptions;
using SPMeta2.Enumerations;
using SPMeta2.Regression.Tests.Base;
using SPMeta2.Regression.Tests.Extensions;
using System.Collections.Generic;
using SPMeta2.Definitions.Fields;
using SPMeta2.Regression.Definitions;
using SPMeta2.Services;
using SPMeta2.ModelHandlers;
using SPMeta2.Definitions.Base;
using SPMeta2.Models;
using SPMeta2.Regression.Definitions.Extended;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Standard.Syntax;

namespace SPMeta2.Regression.Tests.Impl.Scenarios.Webparts
{
    [TestClass]
    public class ContentByQueryWebPartScenariosTest : SPMeta2RegresionScenarioTestBase
    {
        #region constructors



        #endregion

        #region internal

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            InternalInit();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            InternalCleanup();
        }

        #endregion

        #region

        [TestMethod]
        [TestCategory("Regression.Scenarios.Webparts.ContentByQueryWebPart.Lists")]
        public void CanDeploy_ContentByQueryWebPart_AsIs_BindedToList_ByUrl()
        {
            var webpartDef = ModelGeneratorService.GetRandomDefinition<ContentByQueryWebPartDefinition>(def =>
            {
                def.Title = "As is to " + BuiltInListDefinitions.WorkflowTasks.CustomUrl;

                def.WebUrl = "~sitecollection";

                def.ListId = Guid.Empty;
                def.ListUrl = BuiltInListDefinitions.WorkflowTasks.CustomUrl;
            });

            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddHostList(BuiltInListDefinitions.SitePages, list =>
                {
                    list.AddRandomWebPartPage(page =>
                    {
                        page.AddContentByQueryWebPart(webpartDef);
                    });
                });
            });

            TestModel(model);
        }

        [TestMethod]
        [TestCategory("Regression.Scenarios.Webparts.ContentByQueryWebPart.Lists")]
        public void CanDeploy_ContentByQueryWebPart_AsIs_BindedToLibrary_ByUrl()
        {
            var webpartDef = ModelGeneratorService.GetRandomDefinition<ContentByQueryWebPartDefinition>(def =>
            {
                def.Title = "As is to " + BuiltInListDefinitions.StyleLibrary.CustomUrl;

                def.WebUrl = "~sitecollection";

                def.ListId = Guid.Empty;
                def.ListUrl = BuiltInListDefinitions.StyleLibrary.CustomUrl;
            });

            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddHostList(BuiltInListDefinitions.SitePages, list =>
                {
                    list.AddRandomWebPartPage(page =>
                    {
                        page.AddContentByQueryWebPart(webpartDef);
                    });
                });
            });

            TestModel(model);
        }

        #endregion
    }
}
