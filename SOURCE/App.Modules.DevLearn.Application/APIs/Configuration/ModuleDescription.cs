using App.Base.Shared.Models.Contracts;

namespace App.Modules.DevLearn.Application.APIs.Configuration
{
    /// <summary>
    /// Configuration object
    /// used to describe Module.
    /// </summary>
    /// <remarks>
    /// Module developers provide default values.
    /// But as only needed for API Documentation, etc.
    /// and not Routing, are not required to be Static, 
    /// hence they are configurable if required.
    /// </remarks>
    public class ModuleAPIDescription : IHasModuleDescription
    {
        /// <summary>
        /// Public default configurable Title of the Module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public string Title { get; set; } = "TODO:DevLearn:Title";

        /// <summary>
        /// Public configurable Description of the Module
        /// </summary>
        public string Description { get; set; } = "TODO:DevLearn:Description";

        /// <summary>
        /// Public configurable Url to Module Maintainer web page.
        /// </summary>
        public string OrganisationUrl { get; set; } = "TODO:DevLearn:Website Url";

        /// <summary>
        /// public configurable Url to Module maintainer Contact information web page.
        /// </summary>
        public string ContactUrl { get; set; } = "TODO:DevLearn:Contact Url";

    }
}
