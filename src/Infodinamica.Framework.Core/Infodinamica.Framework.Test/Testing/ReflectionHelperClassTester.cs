using System;
using Infodinamica.Framework.Test.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infodinamica.Framework.Test.Testing
{
    [TestClass]
    public class ReflectionHelperClassTester
    {
        [TestMethod]
        public void TestNonStaticClassNonStaticMethod()
        {
            var obj = new DummyObject();
            if (!obj.Class1().Equals("DummyObject"))
                throw new Exception("Se esperaba el valor DummyObject");
        }

        [TestMethod]
        public void TestNonStaticClassStaticMethod()
        {
            if (!DummyObject.Class2().Equals("DummyObject"))
                throw new Exception("Se esperaba el valor DummyObject");
        }


        [TestMethod]
        public void TestStaticClassStaticMethod()
        {
            if (!DummyStaticObject.Class1().Equals("DummyStaticObject"))
                throw new Exception("Se esperaba el valor DummyStaticObject");
        }

        [TestMethod]
        public void TestStaticClassPrivateStaticMethod()
        {
            if (!DummyStaticObject.Class2().Equals("DummyStaticObject"))
                throw new Exception("Se esperaba el valor DummyStaticObject");
        }
    }
}
