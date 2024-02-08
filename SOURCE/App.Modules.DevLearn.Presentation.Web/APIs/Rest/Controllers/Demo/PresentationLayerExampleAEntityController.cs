using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Entities.Demos;
using App.Base.Shared.Models.Messages;
using App.Modules.DevLearn.Presentation.Web.APIs.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.Extensions.Options;

namespace App.Modules.DevLearn.Presentation.Web.APIs.Rest.Controllers.Demo
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
    public class PresentationLayerExampleAEntityController : ControllerBase
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
        internal const string Name = "PresentationLayerExampleAEntity";

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



        static ExampleAEntity[] Records;


        static PresentationLayerExampleAEntityController()
        {
            Records =
                new ExampleAEntity[]{
                new ExampleAEntity(){Enabled=false, Title="A2.01",   Description="* Using a Controller in Referenced Presentation Layer assembly."},
                new ExampleAEntity(){Enabled=false, Title="A2.02",   Description="* Building Response in Controller (not a Lower Service)."},
                new ExampleAEntity(){Enabled=false, Title="A2.03",   Description="* As an array of *internal* system entities (not DTOs)."},
                new ExampleAEntity(){Enabled=false, Title="A2.04",   Description="* Note:"},
                new ExampleAEntity(){Enabled=false, Title="A2.02.1", Description="  * Route defined on Controller"},
                new ExampleAEntity(){Enabled=false, Title="A2.02.1", Description="  * No use of Mapping going on"},
                new ExampleAEntity(){Enabled=false, Title="A2.03",   Description="- Synopsis:"},
                new ExampleAEntity(){Enabled=false, Title="A2.03.1", Description="  + Beguilingly simple enough."},
                new ExampleAEntity(){Enabled=false, Title="A2.03.2", Description="  - Fails basic security recommendations of not exposing internal entities."},
                new ExampleAEntity(){Enabled=false, Title="A2.03.3", Description="  - Brittle Contract, as any change to Entity could break service clients."},
                new ExampleAEntity(){Enabled=false, Title="A2.03.4", Description="  - not Queryable"},
                };
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityController()
        {

        }

        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ExampleAEntity> Get()
        {
            return Records;
        }
    }

}
