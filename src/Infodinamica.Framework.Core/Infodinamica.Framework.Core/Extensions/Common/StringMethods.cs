namespace Infodinamica.Framework.Core.Extensions.Common
{
    public static class StringMethods
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrEmpty(value) || value.Trim().Length == 0;
        }
    }
}
