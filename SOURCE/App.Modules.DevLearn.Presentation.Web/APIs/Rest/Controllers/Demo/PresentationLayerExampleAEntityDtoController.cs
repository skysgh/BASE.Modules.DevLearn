using App.Base.Application.APIs.Messages.V0100.Demo;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Messages;
using App.Modules.DevLearn.Presentation.Web.APIs.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace App.Base.Presentation.Web.APIs.Rest.Implementations.Demo
{
    /// <summary>
    /// A demo controller to help developers
    /// get up to speed on how the framework 
    /// is wired together.
    /// </summary>
    [Route(Route)]
    [ApiController]
    [ForDemoOnly]
    [ApiVersion("1.0")]
    public class PresentationLayerExampleAEntityDtoController : ControllerBase
    {

        /// <summary>
        /// Name of Controller.
        /// <para>
        /// Unique per Protocol per Module.
        /// </para>
        /// <para>
        /// Combined with the Module Key
        /// used to develop the 
        /// Route to the Controller.
        /// </para>
        /// <para>
        /// Note that when a Controller is OData enabled, 
        /// the Name is used to register the 
        /// route in the OData EDM Model.
        /// </para>
        /// </summary>
        internal const string Name = "PresentationLayerExampleAEntityDto";

        /// <summary>
        /// The unique Route to the Controller, combining
        /// <list type="bullet">
        /// <item>Module Key</item>
        /// <item>Protocol based Service Root</item>
        /// <item>API Version</item>
        /// <item>Controller Name</item>
        /// </list>
        /// </summary>
        internal const string Route = $"{ModuleApiRoutingConstants.Protocols.Rest.RoutePrefix}/{Name}";


        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityDtoController()
        {

        }

        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ExampleAEntityDto> Get()
        {
            var values =
            new ExampleAEntityDto[]{
                new ExampleAEntityDto(){Text="A2.2",Description="- straight API calls (not OData)"},
                new ExampleAEntityDto(){Text="A2.3",Description="- to a Controller moved out of the Host Assembly"},
                new ExampleAEntityDto(){Text="A2.4",Description="- and into *Referenced* Presentation Layer assembly,"},
                new ExampleAEntityDto(){Text="A2.5",Description="- that is again not even invoking an *.Application layer services"},
                new ExampleAEntityDto(){Text="A2.6",Description="- but making the result list up in the Controller."},
                new ExampleAEntityDto(){Text="A2.7",Description="- ie. again practically impossible to fail delivering as"},
                new ExampleAEntityDto(){Text="A2.8",Description="- by default ASP.NET Core now caters for the concept of AssemblyParts."},
            };
            return values;
        }
    }

}
