using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Helpers;

namespace Infodinamica.Framework.Test.Tools
{
    internal class DummyObject
    {
        public string Method1()
        {
            return ReflectionHelper.GetCurrentMethod();
        }

        public static string Method2()
        {
            return ReflectionHelper.GetCurrentMethod();
        }

        public string Method3()
        {
            return Method4();
        }

        private string Method4()
        {
            return ReflectionHelper.GetParentMethod();
        }

        public string Class1()
        {
            return ReflectionHelper.GetCurrentClass();
        }

        public static string Class2()
        {
            return ReflectionHelper.GetCurrentClass();
        }
    }
}
