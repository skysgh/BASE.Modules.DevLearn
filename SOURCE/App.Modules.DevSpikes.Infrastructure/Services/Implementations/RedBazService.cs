using App.Modules.DevSpikes.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevSpikes.Infrastructure.Services.Implementations
{
    /// <summary>
    /// Implementation of the 
    /// <see cref="IBazService"/>
    /// </summary>
    public class RedBazService : IBazService
    {
        /// <summary>
        /// Example operation.
        /// </summary>
        /// <returns></returns>
        public string Do()
        {
            return "Red";
        }
    }
}
