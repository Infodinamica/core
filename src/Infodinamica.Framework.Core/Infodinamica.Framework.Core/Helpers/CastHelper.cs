using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Infodinamica.Framework.Core.Extensions.IO;

namespace Infodinamica.Framework.Core.Helpers
{
    /// <summary>
    /// Permite castear tipos de datos
    /// </summary>
    public static class CastHelper
    {
        /// <summary>
        /// Permite castear a un tipo de dato específico
        /// </summary>
        /// <param name="value">Valor a castear</param>
        /// <param name="destinationType">Tipo de dato resultante del casteo</param>
        /// <returns>Objeto del tipo ingresado. Retorna un objeto, por lo cual debe ser nuevamente casteado</returns>
        public static object CastToType(object value, Type destinationType)
        {
            Array valueAsArray = value as Array;
            if (valueAsArray != null)
            {
                if (destinationType.IsArray)
                {
                    var finalArray = Array.CreateInstance(destinationType.GetElementType(), valueAsArray.Length);

                    for (int index = 0; index <= valueAsArray.Length - 1; index++)
                    {
                        object itemConverted = CastToType(valueAsArray.GetValue(index), destinationType.GetElementType());
                        finalArray.SetValue(itemConverted, index);
                    }
                    return finalArray;
                }
                value = ((valueAsArray.Length > 0)
                    ? CastToType(valueAsArray.GetValue(0), destinationType)
                    : null);
            }

            if (value == null || destinationType.IsInstanceOfType(value))
                return value;

            object convertedValue = null;
            var converter = TypeDescriptor.GetConverter(destinationType);
            if (converter.CanConvertFrom(value.GetType()))
            {
                try
                {
                    convertedValue = converter.ConvertFrom(value);
                    return convertedValue;
                }
                catch (Exception)
                {
                    if (converter is NullableConverter && ((NullableConverter)converter).UnderlyingTypeConverter is BaseNumberConverter)
                    {
                        destinationType = Nullable.GetUnderlyingType(destinationType);
                        converter = ((NullableConverter)converter).UnderlyingTypeConverter;
                    }
                    if (converter is BaseNumberConverter)
                    {
                        NumberStyles style = NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                        MethodInfo parseMethod = destinationType.GetMethod("Parse", new Type[]
                        {
                            typeof (string),
                            typeof (NumberStyles),
                            typeof (IFormatProvider)
                        });
                        convertedValue = parseMethod.Invoke(null, new object[]
                        {
                            value,
                            style,
                            CultureInfo.CurrentCulture.GetFormat(typeof (NumberFormatInfo))
                        });
                    }
                    return convertedValue;
                }
            }
            converter = TypeDescriptor.GetConverter(value.GetType());
            if (converter.CanConvertTo(destinationType))
                convertedValue = converter.ConvertTo(value, destinationType);

            return convertedValue;
        }

        /// <summary>
        /// Permite castear un stream a un vector de byte
        /// </summary>
        /// <param name="stream">Stream a castear</param>
        /// <returns>Retorna un vector de byte del stream casteado</returns>
        public static byte[] CastToByteArray(Stream stream)
        {
            byte[] data;
            try
            {
                MemoryStream memoryStream = stream as MemoryStream;
                if (memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    stream.CopyTo(memoryStream);
                }
                data = memoryStream.ToArray();
            }
            finally
            {
                if (stream != null)
                {
                    ((IDisposable)stream).Dispose();
                }
            }
            return data;
        }
    }
}
