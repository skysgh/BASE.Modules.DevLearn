using App.Base.Presentation.Web.Constants;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Messages;
using App.Base.Shared.Models.Messages.API.V0100;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using App.Modules.DevLearn.Presentation.Web.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

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
    public class PresentationLayerExampleAEntityDtoController : ControllerBase
    {



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
