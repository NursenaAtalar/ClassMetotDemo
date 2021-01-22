using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public Customer Add( Customer customer) 
        {
           Console.WriteLine(" Eklemek istediğiniz müşteri adı giriniz");
           customer.Name =  Console.ReadLine();
           Console.WriteLine(customer.Name+" isimli müşteri eklendi.");
            return customer; 
        }
        public Customer Delete(Customer customer)
        {
            Console.WriteLine(" Silmek istediğiniz müşteri adı giriniz");
            customer.Name = Console.ReadLine();
            Console.WriteLine(customer.Name + " isimli müşteri silindi.");
            return customer;
        }
    }
}
