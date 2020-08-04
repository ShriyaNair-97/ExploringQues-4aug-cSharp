using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Dictionary
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 50000
            };
            Customer c2 = new Customer()
            {
                Id = 102,
                Name = "Marrie",
                Salary = 70000
            };
            Customer c3 = new Customer()
            {
                Id = 103,
                Name = "Maggie",
                Salary = 690000
            };
            Dictionary<int, Customer> dictionayCustomer = new Dictionary<int, Customer>();
            dictionayCustomer.Add(c1.Id,c1);
            dictionayCustomer.Add(c2.Id,c2);
            dictionayCustomer.Add(c3.Id,c3);

            Customer c102 = dictionayCustomer[102];
            Console.WriteLine("Id : {0},Name:{1},Salary:{2}",c102.Id,c102.Name,c102.Salary);


            Console.WriteLine("------Using foreach loop------------");
            foreach(var item in dictionayCustomer)
            {
                Console.WriteLine("Key ={0}",item.Key);
                Customer cust = item.Value;
                Console.WriteLine("Details of the employee");
                Console.WriteLine("Id: {0} Name :{1} salary :{2}",cust.Id,cust.Name,cust.Salary);
            }
            Console.WriteLine("-----------------------------");
            foreach(var key in dictionayCustomer)
            {
                Console.WriteLine(dictionayCustomer.Keys);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("whether there is a key or not",dictionayCustomer.ContainsKey(c1.Id));
            Console.WriteLine("-----------------------------");
            Customer cust1;
            if(dictionayCustomer.TryGetValue(101,out cust1))
            {
                Console.WriteLine("Id :{0} Name :{1} Salary:{2}",cust1.Id,cust1.Name,cust1.Salary);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

        }
    }
}
