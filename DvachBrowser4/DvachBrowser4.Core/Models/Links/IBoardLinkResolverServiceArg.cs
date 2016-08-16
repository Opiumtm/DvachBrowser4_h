using Ipatov.ServiceLocator;

namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Аргумент для получения сервиса определения ссылок.
    /// </summary>
    public interface IBoardLinkResolverServiceArg : IResolveServiceParam<IBoardLinkResolver>
    {
        /// <summary>
        /// Тип ссылки.
        /// </summary>
        string LinkTypeId { get; }
    }
}