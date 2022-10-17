using App.Base.Presentation.Web.Constants;
using App.Modules.DevLearn.Shared.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevLearn.Presentation.Web.Constants
{
    /// <summary>
    /// Collection of Constants specific to this
    /// Modules Presentation Layer.
    /// </summary>
    public class AppModuleConstants
    {
            /// <summary>
            /// The Route segment to prepend in front of 
            /// Controllers in this Module.
            /// </summary>
            public const string ModuleRouteSegment = ModuleConstants.Key + "/";

        /// <summary>
        /// Module specific Prefix for REST API Routes.
        /// </summary>
        public const string ModuleRestRoutePrefix = ApiConstants.RestApiRoutePrefix + ModuleRouteSegment;
    }
}
