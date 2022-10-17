using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevLearn.Shared.Constants
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
        public const string Key = "DevLearn";
    }



}
