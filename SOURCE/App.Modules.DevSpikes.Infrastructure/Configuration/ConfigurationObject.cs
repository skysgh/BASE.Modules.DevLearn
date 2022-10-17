using App.Base.Shared.Models.Configuration;

namespace App.Modules.Base.Infrastructure.Configuration
{
    /// <summary>
    /// Demonstration of some kind 
    /// of Configuration Object, 
    /// <para>
    /// Note that it implements <see cref="IConfigurationObject"/>
    /// for Discoverability at the start of the app.
    /// </para>
    /// </summary>
    public class ConfigurationObject : IConfigurationObject
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ConfigurationObject()
        {

        }
        /// <summary>
        /// Static Field used to provide a practical way 
        /// of retrieving the section name under which the configuration
        /// is saved in the app.config or other.
        /// </summary>
        public static string Name = "ConfigurationObject";

        /// <summary>
        /// A Field
        /// </summary>
        public string? Bar { get; set; }

        /// <summary>
        /// Another field
        /// </summary>
        public int Foo {get;set;}

    }
}
