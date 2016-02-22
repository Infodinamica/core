using System;
using System.Reflection;

namespace Infodinamica.Framework.Core.Extensions.Reflection
{
    public static class TypeMethods
    {
        public static bool IsNumeric(this PropertyInfo prop)
        {
            if (
                prop.PropertyType == typeof(sbyte) ||
                prop.PropertyType == typeof(byte) ||
                prop.PropertyType == typeof(short) ||
                prop.PropertyType == typeof(ushort) ||
                prop.PropertyType == typeof(int) ||
                prop.PropertyType == typeof(uint) ||
                prop.PropertyType == typeof(long) ||
                prop.PropertyType == typeof(ulong) ||
                prop.PropertyType == typeof(double) ||
                prop.PropertyType == typeof(decimal) ||
                prop.PropertyType == typeof(SByte) ||
                prop.PropertyType == typeof(Byte) ||
                prop.PropertyType == typeof(Int16) ||
                prop.PropertyType == typeof(Int32) ||
                prop.PropertyType == typeof(Int64) ||
                prop.PropertyType == typeof(UInt16) ||
                prop.PropertyType == typeof(UInt32) ||
                prop.PropertyType == typeof(UInt64) ||
                prop.PropertyType == typeof(Double) ||
                prop.PropertyType == typeof(Decimal) 
                )
            {
                return true;
            }

            return false;
        }

        public static bool IsDate(this PropertyInfo prop)
        {
            return prop.PropertyType == typeof (DateTime);
        }

        public static bool IsTime(this PropertyInfo prop)
        {
            return prop.PropertyType == typeof (TimeSpan);
        }

        public static bool IsDateOrTime(this PropertyInfo prop)
        {
            return prop.IsDate() || prop.IsTime();
        }

        public static bool IsBoolean(this PropertyInfo prop)
        {
            return prop.PropertyType == typeof (Boolean) || prop.PropertyType == typeof (bool);
        }

        public static bool IsNullable(this PropertyInfo prop)
        {
            return !prop.PropertyType.IsValueType || prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof (Nullable<>);
        }
    }
}
