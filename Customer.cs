using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// User define list
namespace Arraylist
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    public class TestCustomer
    {
        static void Main()
        {
            List<Customer> list = new List<Customer>();
            Customer c1 = new Customer { Id = 1, Name = "Scott", City = "Hydrabad", Balance = 25000.00};
            Customer c2 = new Customer { Id = 2, Name = "Smith", City = "bhopal", Balance = 25000.00 };
            Customer c3 = new Customer { Id = 3, Name = "Dave", City = "Nagpur", Balance = 25000.00 };
            Customer c4 = new Customer { Id = 4, Name = "David", City = "Channai", Balance = 25000.00 };
            list.Add(c1); 
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            foreach (Customer c in list)
            {
                Console.WriteLine(c.Id + " " + c.Name + " " + c.City + " " + c.Balance);
            }
            Console.ReadLine();
        }
    }
}
