namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Средство определения ссылок.
    /// </summary>
    public interface IBoardLinkResolver
    {
        /// <summary>
        /// Определить ссылку.
        /// </summary>
        /// <param name="typeId">Тип ссылки.</param>
        /// <param name="value">Строковое представление ссылки.</param>
        /// <returns>Ссылка.</returns>
        IBoardLinkBase Resolve(string typeId, string value);
    }
}