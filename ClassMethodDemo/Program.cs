using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 001;
            customer1.Name = "Doğukan";
            customer1.SurName = "Doğu";

            Customer customer2 = new Customer();
            customer2.Id = 002;
            customer2.Name = "Ali İhsan";
            customer2.SurName = "Çalıkuşu";

            Customer customer3 = new Customer();
            customer3.Id = 003;
            customer3.Name = "Burkay";
            customer3.SurName = "Ağgül";

            Customer customer4 = new Customer();
            customer4.Id = 004;
            customer4.Name = "Fikri";
            customer4.SurName = "Tabar";

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("//Listed Method");
            customerManager.List(customers);

            Console.WriteLine("--------------");
            Console.WriteLine("//Added Method"); 
            customerManager.Add(customer1);
            Console.WriteLine("----------------------------");
            Console.WriteLine("//Updated Method");
            customerManager.Update(customer2);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("//Deleted Method");
            customerManager.Delete(customer3);


        }
    }
}
