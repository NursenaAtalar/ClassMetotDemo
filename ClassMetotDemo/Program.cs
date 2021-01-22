using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer();
            customer1.Id = "123456789";
            customer1.Name = "Ahmet";
            customer1.Surname = "Yılmaz";
            customer1.Age = 32;

            Customer customer2 = new Customer();
            customer2.Id = "987654321";
            customer2.Name = "Ayşe";
            customer2.Surname = "Korkmaz";
            customer2.Age = 45;

            Customer customer3 = new Customer { Id = "246824680" , Name= "Hasan" ,Surname= "Dede" ,Age=65};

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            Console.WriteLine("....Mevcut Müşterilerimiz....");
            foreach (Customer custom in customers)
            {
                Console.WriteLine(custom.Name + " "+ custom.Surname + " / " +custom.Age );
            }

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine(".....Yeni Müşteri Ekle.....");
            customerManager.Add(new Customer());

            Console.WriteLine("....Müşteri Silme....");
            customerManager.Delete(new Customer());





        }
    }
}
