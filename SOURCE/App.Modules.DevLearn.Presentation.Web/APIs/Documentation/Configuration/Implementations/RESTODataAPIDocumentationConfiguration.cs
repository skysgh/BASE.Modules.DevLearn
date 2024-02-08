using App.Base.Application.APIs.Configuration;
using App.Base.Presentation.Web.APIs.Constants;
using App.Base.Presentation.Web.APIs.Documentation.Configuration.Implemenation.Base;
using App.Base.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevLearn.Presentation.Web.APIs.Documentation.Configuration.Implementations
{
    /// <summary>
    /// REST specific implementation of 
    /// Module's common API documentation information.
    /// </summary>
    public class RESTODataAPIDocumentationConfiguration : APIDocumentationConfigurationBase
    {
        /// <inheritdoc/>
        public override string Key { get; } = ModuleApiRoutingConstants.Protocols.OData.GroupIdentifier;

        /// <inheritdoc/>
        public override string Title { get; set; } = $"{ModuleConstants.Key} REST OData Enabled Endpoints";


        /// <inheritdoc/>
        public override string Description { get; set; } = $"v1 REST OData enabled endpoints for {ModuleConstants.Key}.";

        /// <inheritdoc/>
        public override string VersionText { get; set; } = "v1";

    }

}
