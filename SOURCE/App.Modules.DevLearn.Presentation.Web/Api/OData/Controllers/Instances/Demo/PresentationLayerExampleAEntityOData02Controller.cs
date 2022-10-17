using App.Base.Application.Services.Demo;
using App.Base.Infrastructure.Services;
using App.Base.Infrastructure.Services.Demos;
using App.Base.Infrastructure.Services.Demos.Implementations;
using App.Base.Presentation.Web.Constants;
using App.Base.Presentation.Web.Controllers.Implementations.Base;
using App.Base.Shared.Attributes;
using App.Base.Shared.Contracts;
using App.Base.Shared.Models.Messages.API.V0100;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Linq.Expressions;

namespace App.Modules.DevLearn.Presentation.Web.Api.OData.Controllers.Instances.Demo
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
    [Route(ApiConstants.OdataApiRoutePrefix + "[controller]")]
    [ApiVersion("2.0")]
    public class PresentationLayerExampleAEntityOData02Controller :
        ModuleQueryableODataControllerBase<ExampleAEntityDto>
    {
        private readonly IExampleAService _exampleEntityAService;

        /// <summary>
        /// Constructor
        /// </summary>
        public PresentationLayerExampleAEntityOData02Controller(
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
        /// <returns></returns>
        [HttpGet("")]
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
