using App.Base.Presentation.Web.Constants;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Entities.Demos;
using App.Modules.DevLearn.Presentation.Web.Constants;
using Microsoft.AspNetCore.Mvc;

namespace App.Base.Presentation.Web.API.Rest.Implementations.Demo
{
    /// <summary>
    /// A demo controller to help developers
    /// get up to speed on how the framework 
    /// is wired together.
    /// </summary>
    [Route(AppModuleConstants.ModuleRestRoutePrefix + "[controller]")]
    [ApiController]
    [ForDemoOnly]
    [ApiVersion("1.0")]
    public class PresentationLayerExampleAEntityTasksController : ControllerBase
    {
        static ExampleAEntity[] Records;


        static PresentationLayerExampleAEntityTasksController()
        {
            Records =
                new ExampleAEntity[]{
                new ExampleAEntity(){Enabled=false, Title="...",   Description="Base framework featuring:"},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Lowering the entry bar, by starting from a recognised Visual Studio standard template."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Replacing the default <code>IServiceProvider</code> with Lamar for performance/discovery by reflection abilities."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- DDD Component layout, such that <code>Host.Web</code> invokes <code>Presentation.Web</code>, that invokes"},
                new ExampleAEntity(){Enabled=false, Title="                     ",   Description="  <code>Application<code>, which invokes both <code>Infrastructure</code> and <code>Domain</code>, all sharing <code>Shared</code>."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Auto mapping between <i>internal</i> <code>Sys Entities</code> and <i>external</i> versioned <code>DTO Messages</code>."},
                new ExampleAEntity(){Enabled=false, Title="[x]                  ",   Description="- At the <code>Assembly</code> layer (the *true* Application Programming Interface (API) Layer)"},
                new ExampleAEntity(){Enabled=false, Title="[x] Reusability     :",   Description="  So as to be hostable in different <code>Hosts</code> (Web, Console, Test rig) as need be."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- The <code>Host</code> is kept intentionally *thin*,"},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- As is <code>Presentation.Web</code> Layer, as it is only tasked with"},
                new ExampleAEntity(){Enabled=false, Title="   ",   Description="  making the <code>Application</code>'s layer's <code>DTOs</code> web ready."},
                new ExampleAEntity(){Enabled=false, Title="[x] Modularity      :",   Description="- Routing route separation exists between <code>SOAP</code>, <code>REST</code>, <code>ODATA</code>, <code>GRAPHQL</code>."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- OpenAPI is enabled via Swagger."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- ODATA enabled."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Interoperability:",   Description="- OpenAPI and ODATA working without conflict."},
                new ExampleAEntity(){Enabled=false, Title="[x] Extensability   :",   Description="- MODULES directory using reflection to build sum of services offered"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Extensability   :",   Description="- from easily available nuget packages"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Maintainability :",   Description="  permitting development by different teams/groups, without requiring coordination."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Modularity      :",   Description="- Graceful Uploading *and* Unloading of Modules without resetting app/disrupting other users."},
                new ExampleAEntity(){Enabled=false, Title="[ ]                 :",   Description="  permitting the development of an ecosystem of user addons."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Maintainability :",   Description="- Use of EF CodeFirst Fluent Object Definitions, found by Reflection."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Use of an ORM (EF) removes SQL Injection Attach risks (still the No.1)."},
                };



        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityTasksController()
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
