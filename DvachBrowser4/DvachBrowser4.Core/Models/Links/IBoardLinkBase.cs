namespace DvachBrowser4.Models.Links
{
    /// <summary>
    /// Базовый интерфейс ссылки.
    /// </summary>
    public interface IBoardLinkBase
    {
        /// <summary>
        /// Тип ссылки.
        /// </summary>
        string TypeId { get; }

        /// <summary>
        /// Ссылка в форме строки.
        /// </summary>
        string AsString { get; }
    }
}