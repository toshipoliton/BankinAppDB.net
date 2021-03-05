using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinAppDB.net
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BankingSystemContext())
            {
                // Create and save a new BankAccount
                Console.Write("Enter a name for a new BankAccount: ");
                var name = Console.ReadLine();

                Console.Write("Enter a name for a your street: ");
                var street = Console.ReadLine();

                var person = new Person { Name = name, LastName = name, Age=44, Role="Customer"};
                var address = new Address() { Street = street };

                person.HomeAddress = address;

                db.People.Add(person);

                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.People
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
