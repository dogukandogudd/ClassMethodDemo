using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("#"+customer.Id + " "+customer.Name+" "+customer.SurName + " Added. " );
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("#" + customer.Id + " " + customer.Name + " " + customer.SurName + " Updated. ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("#" + customer.Id + " " + customer.Name + " " + customer.SurName + " Deleted. ");
        }

        public void List(Customer[] customer)
        {
            foreach (Customer i in customer)
            {
                Console.WriteLine("#" + i.Id + " " + i.Name + " " + i.SurName + " Listed. ");
            }
            
        }
    }
}
