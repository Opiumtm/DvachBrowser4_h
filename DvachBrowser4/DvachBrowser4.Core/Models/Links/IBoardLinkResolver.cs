namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Imageboard link resolver.
    /// </summary>
    public interface IBoardLinkResolver
    {
        /// <summary>
        /// Resolve link.
        /// </summary>
        /// <param name="typeId">Link type id.</param>
        /// <param name="value">String representation.</param>
        /// <returns>Imageboard link.</returns>
        IBoardLinkBase Resolve(string typeId, string value);
    }
}