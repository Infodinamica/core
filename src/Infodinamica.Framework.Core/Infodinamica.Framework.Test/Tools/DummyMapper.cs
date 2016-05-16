using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Core.Types;

namespace Infodinamica.Framework.Test.Tools
{
    internal class DummyMapper: BaseMapper
    {
        public static DummyPerson2 ToAnotherPerson(DummyPerson person)
        {
            CheckParameter(person);

            try
            {
                var a = 1;
                var b = 0;
                var c = a/b;

                return new DummyPerson2()
                {
                    BirthAt2 = person.BirthAt,
                    Email2 = person.Email,
                    Name2 = person.Name
                };
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
                return null;
            }
        }
    }
}
