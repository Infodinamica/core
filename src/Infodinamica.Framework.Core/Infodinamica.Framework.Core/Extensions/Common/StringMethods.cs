namespace Infodinamica.Framework.Core.Extensions.Common
{
    /// <summary>
    /// Métodos útiles para strings
    /// </summary>
    public static class StringMethods
    {
        /// <summary>
        /// Implementación de IsNullOrWhiteSpace de .NET 4.0, no provisto en .NET 3.5
        /// </summary>
        /// <param name="value">Valor a revisar</param>
        /// <returns>Retorna verdadero si la cadena está vacía, es nula o contiene solo espacios en blanco</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrEmpty(value) || value.Trim().Length == 0;
        }
    }
}
