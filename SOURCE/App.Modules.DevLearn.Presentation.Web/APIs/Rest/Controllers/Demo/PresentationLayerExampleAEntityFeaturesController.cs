using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Entities.Demos;
using App.Modules.DevLearn.Presentation.Web.APIs.Constants;
using Microsoft.AspNetCore.Mvc;

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
    public class PresentationLayerExampleAEntityFeaturesController : ControllerBase
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
        internal const string Name = "PresentationLayerExampleAEntityFeatures";
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


        static PresentationLayerExampleAEntityFeaturesController()
        {
            Records =
                new ExampleAEntity[]{
                new ExampleAEntity(){Enabled=false, Title="...",   Description="Base framework featuring:"},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Starting from a recognised Visual Studio standard template (API + Angular)."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Replace the default <code>IServiceProvider</code> with a more performant/discovery by reflection capable library."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Use DDD component layout approach to define assemblies."},
                new ExampleAEntity(){Enabled=false, Title="                     ",   Description="- Develop a *thin* <code>Host<code>"},
                new ExampleAEntity(){Enabled=false, Title="                     ",   Description="- Develop a *thin* <code>Presentation.Web<code> doing very little than coverting System Entities to DTOs returned from <code>Application</code> assembly."},
                new ExampleAEntity(){Enabled=false, Title="                     ",   Description="- Develop an <code>Application<code> layer to act as true boundary (ie, provide an <i>Application</i> Pogramming Interface)."},
                new ExampleAEntity(){Enabled=false, Title="                     ",   Description="- Returning external <code>DTO</code> API payloads."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Auto mapped from <i>internal</i> shared <code>Sys Entities</code>."},
                new ExampleAEntity(){Enabled=false, Title="[x]                  ",   Description="- Developed from Infrastructure defined System Entity Repositories."},
                new ExampleAEntity(){Enabled=false, Title="[x]                  ",   Description="- Manipulated if/as needed by <code>Domain</code> Services (generally Operations based as oppossed to Query based)."},
                new ExampleAEntity(){Enabled=false, Title="[x] Reusability     :",   Description="  Ensure Controllers can be discovered and registered in Referenced Assemblies (eg: <code>Base.Presentation.Web</code>."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Ensure Controllers can be discovered and registered in non-Referenced Assemblies (eg: a Module.XYZ.Presentation.Web"},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Ensure Controllers can be registered Late (post-App Build event), using exising Services."},
                new ExampleAEntity(){Enabled=false, Title="[x] Maintainability :",   Description="- Ensure Controllers can be registered Late (post-App Build event)"},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Ensure Controllers are routed by ModuleName."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Enable OpenAPI is enabled via Swagger."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Enabled/Register ODATA Controllers with default/no speific routes defined."},
                new ExampleAEntity(){Enabled=false, Title="[x] Interoperability:",   Description="- Enabled/Register ODATA Controllers matching specific attribute defined routes."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Interoperability:",   Description="- OpenAPI and ODATA working without conflict."},
                new ExampleAEntity(){Enabled=false, Title="[x] Extensability   :",   Description="- MODULES directory using reflection to build sum of services offered"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Extensability   :",   Description="- from easily available nuget packages"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Maintainability :",   Description="  permitting development by different teams/groups, without requiring coordination."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Modularity      :",   Description="- Graceful Uploading *and* Unloading of Modules without resetting app/disrupting other users."},
                new ExampleAEntity(){Enabled=false, Title="[ ]                 :",   Description="  permitting the development of an ecosystem of user addons."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Maintainability :",   Description="- Use of EF CodeFirst Fluent Object Definitions, found by Reflection."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Use of an ORM (EF) removes SQL Injection Attach risks (still the No.1)."},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Use DocumentDB"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Use Different Schema per module"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Portable Secure Configuration"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- UX"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Infrastructure as Code"},
                new ExampleAEntity(){Enabled=false, Title="[ ] Security        :",   Description="- Pipeline as Code"},
                };
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityFeaturesController()
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
