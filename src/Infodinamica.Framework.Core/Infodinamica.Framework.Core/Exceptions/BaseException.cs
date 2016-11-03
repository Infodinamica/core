using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Infodinamica.Framework.Core.Exceptions
{
    /// <summary>
    /// Clase base para construcción de excepciones
    /// </summary>
    public abstract class BaseException : Exception, IException
    {
        public bool NeedBeLogged { get; protected set; }
        
        public IList<Exception> InnerExceptions { get; private set; }

        public bool HaveDataErrors
        {
            get
            {
                if (base.Data == null || base.Data.Count < 1)
                    return false;
                return true;
            }
        }

        /// <summary>
        /// Constructor. Se asume que el error DEBE ser logeado
        /// </summary>
        public BaseException() : base()
        {
            NeedBeLogged = true;
            InnerExceptions = new List<Exception>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        public BaseException(bool needBeLogged) : base()
        {
            NeedBeLogged = needBeLogged;
        }

        /// <summary>
        /// Constructor. Se asume que el error DEBE ser logeado
        /// </summary>
        /// <param name="message">Mensaje del error</param>
        public BaseException(string message) : base(message)
        {
            NeedBeLogged = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        /// <param name="message">Mensaje del error</param>
        public BaseException(bool needBeLogged, string message) : base(message)
        {
            NeedBeLogged = needBeLogged;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Mensaje del error</param>
        /// <param name="innerException">Excepción hija</param>
        public BaseException(string message, Exception innerException) : base(message, innerException)
        {
            NeedBeLogged = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="needBeLogged">Indica si el error debe ser logeado</param>
        /// <param name="message">Mensaje del error</param>
        /// <param name="innerException">Excepción hija</param>
        public BaseException(bool needBeLogged, string message, Exception innerException) : base(message, innerException)
        {
            NeedBeLogged = needBeLogged;
        }

        public void AddModelError(string key, string message)
        {
            Data.Add(key, message);
        }

        public override string ToString()
        {
            var currentMessage = this.Message;

            //Por cada detalle en el diccionario, se agrega en el mensaje final
            if(this.Data != null)
                foreach (DictionaryEntry entry in this.Data)
                    currentMessage += string.Format("{0}{1}: {2}", Environment.NewLine, entry.Key, entry.Value);

            //Por cada excepción en la colección de excepciones
            var index = 1;
            if(this.InnerExceptions != null && this.InnerExceptions.Any())
                foreach (var ex in InnerExceptions)
                {
                    currentMessage += string.Format("{0}{0}Inner Exception {1}: {2}", Environment.NewLine, index, ex.ToString());
                    index++;
                }

            return currentMessage;
        }

        public void AddInnerException(Exception ex)
        {
            this.InnerExceptions.Add(ex);
        }

    }
}
