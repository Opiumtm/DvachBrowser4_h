using System;
using Ipatov.ServiceLocator;

namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Класс-помощник для определения ссылок 
    /// </summary>
    public static class LinkResolveHelper
    {
        /// <summary>
        /// Определить ссылку.
        /// </summary>
        /// <param name="container">Контейнер.</param>
        /// <param name="linkTypeId">Тип ссылки.</param>
        /// <param name="link">Строковое представление ссылки.</param>
        /// <returns>Объект ссылки.</returns>
        public static IBoardLinkBase ResolveLink(this IServiceContainer container, string linkTypeId, string link)
        {
            if (container == null) throw new ArgumentNullException(nameof(container));
            return container.Resolve(new LinkResolveArg(linkTypeId))?.Resolve(linkTypeId, link);
        }

        private sealed class LinkResolveArg : IBoardLinkResolverServiceArg
        {
            public LinkResolveArg(string linkTypeId)
            {
                LinkTypeId = linkTypeId;
            }

            public Guid? Id => null;
            public bool? Create => null;
            public string LinkTypeId { get; }
        }
    }
}