using Ipatov.ServiceLocator;

namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Imageboard link resolver service discovery argument.
    /// </summary>
    public interface IBoardLinkResolverServiceArg : IResolveServiceParam<IBoardLinkResolver>
    {
        /// <summary>
        /// Link type ID.
        /// </summary>
        string LinkTypeId { get; }
    }
}