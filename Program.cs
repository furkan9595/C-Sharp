using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CustomerManager customerManager = new CustomerManager();
            customerManager.Job_Name = "Bilgisayar Mühendisi";
            customerManager.CompanyName = "Turk Telekom";
            customerManager.TaskName = "Software Developer";


            Customer customerName =new Customer();
            customerName.Id = 1;
            customerName.Name = "furkan";
            customerName.Soyadi = "kalkan";
            customerName.Sehir = "İstanbul";
            
            
            Console.WriteLine(customerName.Id);
            Console.WriteLine(customerName.Name);     
            Console.WriteLine(customerName.Soyadi);
           
            Console.WriteLine(customerName.Sehir);

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "furkan",
                Soyadi= "kalkan",
                Sehir= "İstanbul"

            };


            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);
            Console.WriteLine(customer2.Soyadi);
            Console.WriteLine(customer2.Sehir);



            Console.ReadLine();



        }
    }

     

      

    
}
