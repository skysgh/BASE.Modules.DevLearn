using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.DevSpikes.Infrastructure.Services
{
    /// <summary>
    /// Contract for a Generic Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBarService<T>
    {
        /// <summary>
        /// Example operation
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Do(string text);
    }
}
