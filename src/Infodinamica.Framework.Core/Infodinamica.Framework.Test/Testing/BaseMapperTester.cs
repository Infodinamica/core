using System;
using Infodinamica.Framework.Test.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infodinamica.Framework.Test.Testing
{
    [TestClass]
    public class BaseMapperTester
    {
        [TestMethod]
        public void TestErrorHandler()
        {
            try
            {
                var person = new DummyPerson()
                {
                    BirthAt = new DateTime(1985, 4, 5),
                    Email = "some@address.com",
                    Name = "Some Name"
                };

                var person2 = DummyMapper.ToAnotherPerson(person);
            }
            catch (Exception ex)
            {
                if (!ex.Message.Equals("Se ha producido un error inesperado al mapear el objeto. El error se produjo en la clase DummyMapper, método ToAnotherPerson. Revise la pila de excepciones para mayor información"))
                    throw new Exception("Prueba no superada");
            }
            
        }

        [TestMethod]
        public void TestCheckParameter()
        {
            try
            {
                var person2 = DummyMapper.ToAnotherPerson(null);
            }
            catch (Exception ex)
            {
                if (!ex.Message.Equals("El parámetro es nulo y no puede ser mapeado. El parámetro entregado es del tipo DummyPerson, en la clase DummyMapper, en el método ToAnotherPerson"))
                    throw new Exception("Prueba no superada");
            }
        }
    }
}
