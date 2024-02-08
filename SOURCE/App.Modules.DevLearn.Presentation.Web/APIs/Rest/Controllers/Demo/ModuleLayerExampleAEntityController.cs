using App.Base.Application.APIs.Messages.V0100.Demo;
using App.Base.Infrastructure.Factories;
using App.Base.Infrastructure.Services;
using App.Base.Shared.Attributes;
using App.Modules.DevLearn.Infrastructure.Configuration;
using App.Modules.DevLearn.Presentation.Web.APIs.Constants;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace App.Modules.DevLearn.Presentation.Web.APIs.Rest.Implementations.Demo.Demo
{
    /// <summary>
    /// REST API Controller for Weather Forecasting.
    /// </summary>
    [ForDemoOnly]
    [ApiController]
    [Route(Route)]
    public class ModuleLayerExampleAEntityController : ControllerBase
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
        internal const string Name = "ModuleLayerExampleAEntity";

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


        private readonly ILogger<ModuleLayerExampleAEntityController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options1"></param>
        /// <param name="options"></param>
        /// <param name="c"></param>
        /// <param name="logger"></param>
        public ModuleLayerExampleAEntityController(
            ConfigurationObject options1,
            IOptions<ConfigurationObject> options,
            IContainer c,
            //ModuleDbContext baseModuleDbContext,
            ILogger<ModuleLayerExampleAEntityController> logger)
        {

            var r1 = ServiceLocator.Instance;
            var r2 = ServiceLocator.Get<IDbContextPreCommitService>();


            //baseModuleDbContext.Database.EnsureCreated();
            //var r2 = baseModuleDbContext.Database.CanConnect();

            _logger = logger;

            //var r = fooservice.SayHello("Tom");

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
                new ExampleAEntityDto(){Text="A3.01",Description="* using a Controller moved out of the Host Assembly"},
                new ExampleAEntityDto(){Text="A3.02",Description="* and into *Non-Referenced* Module's Presentation Layer assembly,"},
                new ExampleAEntityDto(){Text="A3.03",Description="* that is building response in Controller (agian not a lower layer Service),"},
                new ExampleAEntityDto(){Text="A3.04",Description="- returing a list of DTOs (as oppossed to exposing internal sys entities)."},
                new ExampleAEntityDto(){Text="A3.05",Description="- Note:"},
                new ExampleAEntityDto(){Text="A3.06",Description="  - A REST Controller."},
                new ExampleAEntityDto(){Text="A3.07",Description="  - Path defined on Controller."},
                new ExampleAEntityDto(){Text="A3.08",Description="  - Reflection used to find *un-Referenced* Module."},
                new ExampleAEntityDto(){Text="A3.09",Description="* Analysis:"},
                new ExampleAEntityDto(){Text="A3.10",Description="  + Using DTOs, rather than exposing internal Sys Entites."},
                new ExampleAEntityDto(){Text="A3.11",Description="  + Foundation of Modular plugin approach being laid down."},
                new ExampleAEntityDto(){Text="A3.12",Description="  - No Queryability."},
            };
            return values;


        }
    }
}