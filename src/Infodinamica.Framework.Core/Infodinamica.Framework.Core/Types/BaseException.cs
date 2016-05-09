﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infodinamica.Framework.Core.Types
{
    /// <summary>
    /// Clase base para construcción de excepciones
    /// </summary>
    public abstract class BaseException : Exception, IException
    {
        public bool NeedBeLogged { get; protected set; }
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

    }
}
