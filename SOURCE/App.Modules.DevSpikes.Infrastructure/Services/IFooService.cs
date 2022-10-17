namespace App.Modules.DevSpikes.Infrastructure.Services
{
    /// <summary>
    /// Contract for a demo service.
    /// </summary>
    public interface IFooService
    {
        /// <summary>
        /// Demo operation.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        string SayHello(string name);
    }
}
