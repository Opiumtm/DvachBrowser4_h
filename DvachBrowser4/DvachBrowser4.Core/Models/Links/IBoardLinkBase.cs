namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Imageboard link base.
    /// </summary>
    public interface IBoardLinkBase
    {
        /// <summary>
        /// Link type id.
        /// </summary>
        string TypeId { get; }

        /// <summary>
        /// Link as string.
        /// </summary>
        string AsString { get; }
    }
}