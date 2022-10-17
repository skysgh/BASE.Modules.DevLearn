namespace App.Modules.DevSpikes.Shared.Entities
{
    /// <summary>
    /// Person Entity
    /// <para>
    /// Persisted via a <c>DbContext</c>.
    /// </para>
    /// </summary>
    public class Example
    {

        /// <summary>
        /// An Record Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// An example property
        /// </summary>
        public string? Text { get; set; }
    }
}