using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Containers;

namespace Infodinamica.Framework.Core.Extensions.Dictionary
{
    /// <summary>
    /// Extensiones para diccionarios
    /// </summary>
    public static class DictionaryMethods
    {
        /// <summary>
        /// Transforma un diccionario en un listado de PlainItem
        /// </summary>
        /// <typeparam name="T">Tipo de dato a castear</typeparam>
        /// <param name="source">Diccionario a castear</param>
        /// <returns>Listado de PlainItem</returns>
        public static IList<PlainItem> ToList<T>(this IDictionary<T, string> source) where T:struct
        {
            return source.Select(i => new PlainItem() {Text = i.Value, Value = i.Key.ToString()}).ToList();
        }
    }
}
