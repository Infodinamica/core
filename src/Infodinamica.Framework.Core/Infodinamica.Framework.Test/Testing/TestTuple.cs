using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infodinamica.Framework.Core.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infodinamica.Framework.Test.Testing
{
    /// <summary>
    /// Descripción resumida de TestTuple
    /// </summary>
    [TestClass]
    public class TestTuple
    {

        [TestMethod]
        public void CreateTupleByProperties()
        {
            var date = DateTime.Now;
            var number = 10;
            var text = "hello!";

            var tuple = new Tuple<string, DateTime, int>();
            tuple.Item3 = number;
            tuple.Item2 = date;
            tuple.Item1 = text;

            if (tuple.Item3 != number || tuple.Item2 != date || tuple.Item1 != text)
                throw new Exception("Tuple lost values");
        }

        [TestMethod]
        public void CreateTupleByConstructor()
        {
            var date = DateTime.Now;
            var number = 10;
            var text = "hello!";

            var tuple = new Tuple<string, DateTime, int>(text, date, number);
            
            if (tuple.Item3 != number || tuple.Item2 != date || tuple.Item1 != text)
                throw new Exception("Tuple lost values");
        }
    }
}
