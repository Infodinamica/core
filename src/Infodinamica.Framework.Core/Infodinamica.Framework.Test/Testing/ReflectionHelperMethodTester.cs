using System;
using Infodinamica.Framework.Test.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infodinamica.Framework.Test.Testing
{
    [TestClass]
    public class ReflectionHelperMethodTester
    {
        [TestMethod]
        public void TestNonStaticClassNonStaticMethod()
        {
            var obj = new DummyObject();
            if (!obj.Method1().Equals("Method1"))
                throw new Exception("Se esperaba el valor Method1");
        }

        [TestMethod]
        public void TestNonStaticClassStaticMethod()
        {
            if (!DummyObject.Method2().Equals("Method2"))
                throw new Exception("Se esperaba el valor Method2");
        }


        [TestMethod]
        public void TestStaticClassStaticMethod()
        {
            if (!DummyStaticObject.Method1().Equals("Method1"))
                throw new Exception("Se esperaba el valor Method1");
        }

        [TestMethod]
        public void TestStaticClassPrivateStaticMethod()
        {
            if (!DummyStaticObject.Method2().Equals("Method3"))
                throw new Exception("Se esperaba el valor Method3");
        }

        [TestMethod]
        public void TestStaticClassParentStaticMethod()
        {
            if (!DummyStaticObject.Method4().Equals("Method4"))
                throw new Exception("Se esperaba el valor Method4");
        }

        [TestMethod]
        public void TestNonStaticClassParentMethod()
        {
            var obj = new DummyObject();
            if (!obj.Method3().Equals("Method3"))
                throw new Exception("Se esperaba el valor Method3");
        }
    }
}
