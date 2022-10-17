
namespace App.Modules.DevSpikes.Shared.Constants
{
    /// <summary>
    /// A static class of Constants used in
    /// this logical Module.
    /// <para>
    /// The class is public to allow the rest of 
    /// the Logical Module to reference it, 
    /// but Base or any other logical module probably
    /// should not (in order to not hard ref the module).
    /// </para>
    /// </summary>
    public static class ModuleConstants
    {
        /// <summary>
        /// The unique key to disambiguate this 
        /// logical module from others.
        /// </summary>
        public const string Key = "DevSpikes";

        /// <summary>
        /// The unique key used to define the EF schema
        /// </summary>
        public const string DbSchemaKey = Key;

        /// <summary>
        /// The name of the connection string 
        /// used by this Logical Module
        /// </summary>
        public const string DbConnectionStringName = Base.Shared.Constants.ModuleConstants.DbConnectionStringName;
    }

}
