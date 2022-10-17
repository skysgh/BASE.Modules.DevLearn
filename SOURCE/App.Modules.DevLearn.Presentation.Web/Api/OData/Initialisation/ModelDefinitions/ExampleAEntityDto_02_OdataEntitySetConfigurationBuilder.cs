﻿using App.Base.Presentation.Web.Api.Odata.Initialisation;
using App.Base.Presentation.Web.Initialisation.OData.Models.Base;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Entities.Demos;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using App.Modules.DevLearn.Presentation.Web.Api.OData.Controllers.Instances.Demo;
using Microsoft.OData.ModelBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Base.Presentation.Web.Initialisation.OData.Models
{

    /// <summary>
    /// An example of 
    /// an implementation of
    /// <see cref="IModuleOdataEntitySetConfigurationBuilder"/>
    /// invoked by <c>ScanForAppODataMapDefinitions</c>
    /// then by <c>ConfigureAppForOData</c>
    /// within which one uses the passed
    /// OData builder to build an 
    /// <see cref="EntitySetConfiguration{TEntity}"/>
    /// which one then uses to define its properties.
    /// </summary>
    [ForDemoOnly]
    public class ExampleAEntityDto_02_OdataEntitySetConfigurationBuilder :
        ODataEntitySetConfigurationBuilderBase
            <
            ExampleAEntityDto, 
            PresentationLayerExampleAEntityOData02Controller
            >

    {

        /// <inheritdoc/>
        //public override EntityTypeConfiguration<ExampleAEntityDto> Define(ODataModelBuilder builder)
        public override void Define(ODataModelBuilder builder)
        {
            // Really stupid part of OData is that one defines
            // controller with the string name of the controller.
            // Go figure.
            string controllerName = 
                typeof(PresentationLayerExampleAEntityOData02Controller)
                .GetODataControllerModelName();

            var entitySetConfiguration = builder
                .EntitySet<ExampleAEntityDto>(controllerName)
                .EntityType;

            // An Entity has a Key:
            entitySetConfiguration.HasKey(x => x.Id);

            // Has Properties:
            entitySetConfiguration.Property(x => x.Text);
            entitySetConfiguration.Property(x => x.Description);

            // If we return something, it makes the method Generic
            // which means interface has to be generic
            // which makes it hard/impossible? to register and invoke
            // later
            //return entitySetConfiguration;
        }

    }
}
