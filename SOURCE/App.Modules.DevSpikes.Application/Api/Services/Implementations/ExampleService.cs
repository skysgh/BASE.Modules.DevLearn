using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevSpikes.Application.Api.Services.Implementations
{
    /// <summary>
    /// An ecample implementation of the
    /// <see cref="IExampleService"/>
    /// service contract.
    /// </summary>
    public class ExampleService : IExampleService
    {
        /// <inheritdoc/>
        
        public string Do()
        {
            return "done.";
        }
    }
}
