using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Helpers;

namespace Infodinamica.Framework.Test.Tools
{
    internal static class DummyStaticObject
    {
        public static string Method1()
        {
            return ReflectionHelper.GetCurrentMethod();
        }

        public static string Method2()
        {
            return Method3();
        }

        private static string Method3()
        {
            return ReflectionHelper.GetCurrentMethod();
        }

        public static string Method4()
        {
            return Method5();
        }

        private static string Method5()
        {
            return ReflectionHelper.GetParentMethod();
        }

        public static string Class1()
        {
            return ReflectionHelper.GetCurrentClass();
        }

        public static string Class2()
        {
            return Class3();
        }

        private static string Class3()
        {
            return ReflectionHelper.GetCurrentClass();
        }
    }
}
