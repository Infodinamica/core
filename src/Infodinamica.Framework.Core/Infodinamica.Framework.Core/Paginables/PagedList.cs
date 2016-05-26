using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infodinamica.Framework.Core.Paginables
{
    /// <summary>
    /// Contiene los elementos y la información de la paginación actual
    /// </summary>
    /// <typeparam name="T">Tipo de dato a almacenar</typeparam>
    public class PagedList<T> : Collection<T> where T : class
    {
        /// <summary>
        /// Información de la página
        /// </summary>
        public IPage Page { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="list">Listado de elementos</param>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        public PagedList(IList<T> list, int amountOfElements)
            : base(list)
        {
            Page = new Page(amountOfElements);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="list">Listado de elementos</param>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        /// <param name="pageSize">Tamaño de página</param>
        public PagedList(IList<T> list, int amountOfElements, short pageSize)
            : base(list)
        {
            Page = new Page(amountOfElements, pageSize);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="list">Listado de elementos</param>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        /// <param name="pageSize">Tamaño de página</param>
        /// <param name="currentPage">Página actual</param>
        public PagedList(IList<T> list, int amountOfElements, short pageSize, int currentPage)
            : base(list)
        {
            Page = new Page(amountOfElements, pageSize, currentPage);
        }
    }
}
