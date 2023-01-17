using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    { 
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added : "+ customer.FirstName +" "+ customer.LastName);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer listed : "+ customer.FirstName +" "+ customer.LastName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : "+ customer.FirstName +" "+ customer.LastName);
        }
    }
}
