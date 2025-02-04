using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal static class Repository
    {
        public static List<Customer> Customers { get; set; } =
            Customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Foo",
                    PhoneNumber = "0599955598",
                    EmailAddress = "test@test.com"
                },
                new Customer()
                {
                    Id = 1,
                    Name = "Doo",
                    PhoneNumber = "05696969696",
                    EmailAddress = "testor@test.com"
                },
            };

    }
}
