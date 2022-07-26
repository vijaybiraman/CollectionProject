using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryproject;
namespace TestApplication
{
    internal class Program 
    {
     static void Main(string[] args)
     { 
           ProductName name = new ProductName();

           Console.WriteLine("1.Add");
            Console.WriteLine("2.delete");
            Console.WriteLine("3.DisplayAll");
            Console.WriteLine("4.serach");
            Console.WriteLine("5.query");
            Console.WriteLine("6.quite");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num <= 5)
            {
                if (num == 1)
                {
                    name.AddProduct();
                }
                if (num == 2)
                {
                    name.DeleteProduct();
                }
                if (num == 3)
                {
                    name.DisplayAllproduct();
                }
                if (num == 4)
                {
                    name.SearchProduct();
                }
                if (num == 5)
                {
                    name.QueryPrice();
                }
                Console.WriteLine("Enter the number");
                 num = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
