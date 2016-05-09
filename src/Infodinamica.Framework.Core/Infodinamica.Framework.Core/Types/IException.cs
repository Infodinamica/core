using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Infodinamica.Framework.Core.Types
{
    /// <summary>
    /// Interfaz base de excepciones
    /// </summary>
    public interface IException
    {
        /// <summary>
        /// Indica si el error debe ser logeado
        /// </summary>
        bool NeedBeLogged { get; }

        /// <summary>
        /// Indica si existen mensajes en el diccionario Data
        /// </summary>
        bool HaveDataErrors { get; }
        
        /// <summary>
        /// Agrega un nuevo elemento al diccionario de errores Data
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        void AddModelError(string key, string message);
    }
}
