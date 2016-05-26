namespace Infodinamica.Framework.Core.Paginables
{
    /// <summary>
    /// Interfaz que contiene la información de la página actual y de la cantidad de páginas existentes
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// Tamaño de la página
        /// </summary>
        short PageSize { get; }

        /// <summary>
        /// Cantidad de elementos
        /// </summary>
        int AmountOfElements { get; }

        /// <summary>
        /// Cantidad de páginas
        /// </summary>
        int AmountOfPages { get; }

        /// <summary>
        /// Página actual
        /// </summary>
        int CurrentPage { get; }

        /// <summary>
        /// Indica si tiene una página siguiente
        /// </summary>
        bool HasNextPage { get; }

        /// <summary>
        /// Indica si tiene una página previa
        /// </summary>
        bool HasPrevPage { get; }
    }
}
