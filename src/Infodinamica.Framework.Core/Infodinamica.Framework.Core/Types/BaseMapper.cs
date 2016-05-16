using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Helpers;
using Infodinamica.Framework.Core.Resources;

namespace Infodinamica.Framework.Core.Types
{
    /// <summary>
    /// Clase base para el mapeo de objetos
    /// </summary>
    public abstract class BaseMapper
    {
        /// <summary>
        /// Revisa que el parámetro no sea nulo y arroja un error en caso que lo sea
        /// </summary>
        /// <typeparam name="T">Tipo de dato a revisar</typeparam>
        /// <param name="parameter">Parámetro a revisar</param>
        protected static void CheckParameter<T>(T parameter)where T: class
        {
            if(parameter == null)
                throw new CustomException(true, string.Format(ErrorMessages.NullParameter, typeof(T).Name, ReflectionHelper.GetParentClass(), ReflectionHelper.GetParentMethod()));
        }

        /// <summary>
        /// Controla las excepciones no controladas
        /// </summary>
        /// <param name="ex">Error que ocurrió</param>
        protected static void ErrorHandler(Exception ex)
        {
            throw new CustomException(true, string.Format(ErrorMessages.UnexpectedError, ReflectionHelper.GetParentClass(), ReflectionHelper.GetParentMethod()), ex);
        }
    }
}
