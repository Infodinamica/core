using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
#if(NET40)
using System.ComponentModel.DataAnnotations;
#endif

namespace Infodinamica.Framework.Core.Helpers
{
    /// <summary>
    /// Contiene utilidades para trabajar con enums
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Obtiene los valores y nombres del enum
        /// </summary>
        /// <typeparam name="T">Enum a leer</typeparam>
        /// <returns>Diccionario en donde el campo key corresponde al valor del enum, mientras que el campo value corresponde al nombre del Enum</returns>
        public static IDictionary<int, string> GetValuesAndNames<T>()
        {
            var elements = new Dictionary<int, string>();
            foreach (var element in Enum.GetValues(typeof(T)))
            {
                elements.Add((int)element, element.ToString());
            }
            return elements;
        }

#if(NET40)
        /// <summary>
        /// Obtiene los valores y DisplayAttribute configurado en el Enum. En caso de no estar configurado el attribute, muestra el nombre del item del Enum
        /// </summary>
        /// <typeparam name="T">Enum a leer</typeparam>
        /// <returns>Diccionario en donde el campo key corresponde al valor del enum, mientras que el campo value corresponde al nombre del enum</returns>
        public static IDictionary<int, string> GetValuesAndDisplayNames<T>()
        {
            var elements = new Dictionary<int, string>();
            foreach (var element in Enum.GetValues(typeof(T)))
            {
                var name = GetDisplayValue(element);
                if (string.IsNullOrWhiteSpace(name))
                    name = element.ToString();
                elements.Add((int)element, name);
            }
            return elements;
        }

        /// <summary>
        /// Obtiene el DisplayAttribute de un elemento dado de un Enum
        /// </summary>
        /// <typeparam name="T">Tipo del Enum a leer</typeparam>
        /// <param name="value">Item del enum a leer</param>
        /// <returns>Retorna el DisplayAttribute configurado (en caso de existir) o retorna un string vacío en caso de no estarlo</returns>
        public static string GetDisplayValue<T>(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null || descriptionAttributes[0] == null) return string.Empty;

            if(descriptionAttributes[0].ResourceType != null)
            {
                var property = descriptionAttributes[0].ResourceType.GetProperty(value.ToString());
                if(property != null)
                {
                    var resourceValue = property.GetValue(property, null);
                    if(resourceValue != null && !string.IsNullOrWhiteSpace(resourceValue.ToString()))
                        return resourceValue.ToString();
                }
            }

            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }
#endif

    }
}
