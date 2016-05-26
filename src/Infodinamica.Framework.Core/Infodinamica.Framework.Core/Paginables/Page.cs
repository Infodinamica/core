using System;

namespace Infodinamica.Framework.Core.Paginables
{
    /// <summary>
    /// Contiene la información de la página actual y de la cantidad de páginas existentes
    /// </summary>
    public class Page: IPage
    {
        
        public short PageSize { get; private set; }
        public int AmountOfElements { get; private set; }
        public int AmountOfPages { get; private set; }
        public int CurrentPage { get; private set; }
        public bool HasNextPage { get; private set; }
        public bool HasPrevPage { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        public Page(int amountOfElements)
        {
            CurrentPage = 1;
            PageSize = 20;
            AmountOfElements = amountOfElements;
            ProcessPages();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        /// <param name="pageSize">Tamaño de página</param>
        public Page(int amountOfElements, short pageSize)
        {
            CurrentPage = 1;
            PageSize = pageSize;
            AmountOfElements = amountOfElements;
            ProcessPages();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="amountOfElements">Cantidad de elementos</param>
        /// <param name="pageSize">Tamaño de página</param>
        /// <param name="currentPage">Página actual</param>
        public Page(int amountOfElements, short pageSize, int currentPage)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            AmountOfElements = amountOfElements;
            ProcessPages();
        }

        private void ProcessPages()
        {
            //Set amount of pages
            if (PageSize > AmountOfElements)
                AmountOfPages = 1;
            else
            {
                var amountOfPagesWithDecimals = (decimal)AmountOfElements / (decimal)PageSize;
                if (amountOfPagesWithDecimals - Math.Truncate(amountOfPagesWithDecimals) > 0)
                    AmountOfPages = (int)Math.Truncate(amountOfPagesWithDecimals) + 1;
                else
                    AmountOfPages = (int)Math.Truncate(amountOfPagesWithDecimals);
            }

            //Set next pages
            if (CurrentPage < AmountOfPages)
                HasNextPage = true;
            else
                HasNextPage = false;

            //Set prev pages
            if (CurrentPage > 1)
                HasPrevPage = true;
            else
                HasPrevPage = false;
        }
    }
}
