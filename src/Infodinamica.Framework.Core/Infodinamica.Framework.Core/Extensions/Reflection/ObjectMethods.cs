using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Helpers;

namespace Infodinamica.Framework.Core.Extensions.Reflection
{
    /// <summary>
    /// Extensiones para objetos
    /// </summary>
    public static class ObjectMethods
    {
        /// <summary>
        /// Permite castear a un tipo de dato específico
        /// </summary>
        /// <param name="value">Valor a castear</param>
        /// <param name="destinationType">Tipo de dato resultante del casteo</param>
        /// <returns>Objeto del tipo ingresado. Retorna un objeto, por lo cual debe ser nuevamente casteado</returns>
        public static object CastToType(this object value, Type destinationType)
        {
            return CastHelper.CastToType(value, destinationType);
        }
    }
}
