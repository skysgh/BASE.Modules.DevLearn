using App.Base.Application.APIs.Messages.V0100.Demo;
using App.Base.Presentation.Web.APIs.OData.Initialisation;
using App.Base.Presentation.Web.APIs.OData.Initialisation.ModelDefinitions.Base;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Entities.Demos;
using App.Modules.DevLearn.Presentation.Web.APIs.OData.Controllers.Demo;
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
    public class ExampleAEntityDto_03_OdataEntitySetConfigurationBuilder :
        ODataEntitySetConfigurationBuilderBase
            <
            ExampleAEntityDto, 
            PresentationLayerExampleAEntityOData03Controller
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
                typeof(PresentationLayerExampleAEntityOData03Controller)
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
