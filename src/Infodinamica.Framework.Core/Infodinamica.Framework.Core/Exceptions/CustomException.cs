using System;
using System.Collections.Generic;

namespace Infodinamica.Framework.Core.Exceptions
{
    /// <summary>
    /// Error estandar de las aplicaciones
    /// </summary>
    public class CustomException: BaseException
    {
        /// <summary>
        /// Constructor. Se asume que el error DEBE ser logeado
        /// </summary>
        public CustomException() : base()
        {
            NeedBeLogged = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        public CustomException(bool needBeLogged) : base()
        {
            NeedBeLogged = needBeLogged;
        }

        /// <summary>
        /// Constructor. Se asume que el error DEBE ser logeado
        /// </summary>
        /// <param name="message">Mensaje del error</param>
        public CustomException(string message) : base(message)
        {
            NeedBeLogged = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        /// <param name="message">Mensaje del error</param>
        public CustomException(bool needBeLogged, string message) : base(message)
        {
            NeedBeLogged = needBeLogged;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Mensaje del error</param>
        /// <param name="innerException">Excepción hija</param>
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            NeedBeLogged = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        /// <param name="message">Mensaje del error</param>
        /// <param name="innerException">Excepción hija</param>
        public CustomException(bool needBeLogged, string message, Exception innerException) : base(message, innerException)
        {
            NeedBeLogged = needBeLogged;
        }

    }
}
