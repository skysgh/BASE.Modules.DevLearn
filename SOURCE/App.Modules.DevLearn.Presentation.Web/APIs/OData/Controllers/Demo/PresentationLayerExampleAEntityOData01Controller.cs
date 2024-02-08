using App.Base.Application.APIs.Messages.V0100.Demo;
using App.Base.Application.Services.Demo;
using App.Base.Infrastructure.Services;
using App.Base.Presentation.Web.APIs.Constants;
using App.Base.Presentation.Web.APIs.OData.Controllers.Base;
using App.Base.Shared.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Linq.Expressions;

namespace App.Modules.DevLearn.Presentation.Web.APIs.OData.Controllers.Demo
{
    /// <summary>
    /// A demo controller to help developers
    /// get up to speed on how the framework 
    /// is wired together.
    /// <para>
    /// NOTE:
    /// This is really the most stupid part 
    /// of OData -- that one defines
    /// controller with the string name of the controller.
    /// Go figure.
    /// </para>
    /// </summary>
    [ForDemoOnly]
    [ODataAttributeRouting]
    [ApiVersion("1.0")]
    [Route(Route)]
    public class PresentationLayerExampleAEntityOData01Controller :
        AppQueryableODataControllerBase<ExampleAEntityDto>
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
        internal const string Name = "PresentationLayerExampleAEntityOData01";

        /// <summary>
        /// The unique Route to the Controller, combining
        /// <list type="bullet">
        /// <item>Module Key</item>
        /// <item>Protocol based Service Root</item>
        /// <item>API Version</item>
        /// <item>Controller Name</item>
        /// </list>
        /// </summary>
        internal const string Route = $"{ModuleApiRoutingConstants.Protocols.OData.RoutePrefix}/{Name}";

        private readonly IExampleAService _exampleEntityAService;

        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityOData01Controller(
            IPrincipalService principalService,
            IExampleAService exampleEntityAService
            )
            : base(principalService)
        {
            _exampleEntityAService = exampleEntityAService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you put HTTPGet(""), it turns out to Duplicate
        /// what is being done by Convention somwhere else.
        /// And causes an error.
        /// </para>
        /// </remarks>
        /// <returns></returns>
        [HttpGet("Get")]
        [EnableQuery(PageSize = 100)]
        public IActionResult Get()
        {
            return Ok(_exampleEntityAService.Get());
        }

        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <param name="expandProperties"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override IQueryable<ExampleAEntityDto> Get(params Expression<Func<ExampleAEntityDto, object>>[] expandProperties)
        {

            var results = _exampleEntityAService.Get();

            return results;

        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        protected override void Put(ExampleAEntityDto value)
        {
            throw new NotImplementedException();
        }
    }

}
