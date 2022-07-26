using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryproject
{
    public class ProductName
    {
        List<product> list = new List<product>();
        
        public void AddProduct()
        {
            Console.WriteLine("Enter product name");
            string productname = Console.ReadLine();
            Console.WriteLine("Enter product price");
            double price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            product pro = new product();
            pro.ProductName = productname;
            pro.Price = price;
            pro.Quantity = quantity;
            list.Add(pro);
            
        }
        public void DeleteProduct()
        {
            try
            {
                Console.WriteLine("Enter the product name");
                string produt = Console.ReadLine();
                foreach (var i in list)
                {
                    if (i.ProductName == produt)
                    {

                        list.Remove(i);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayAllproduct()
        {
          foreach(var i in list)
            {
                Console.WriteLine("ProductName :"+i.ProductName + ", price :"+ i.Price + ", Quantity :"+ i.Quantity);
            }
        }

        public void SearchProduct()
        {
            Console.WriteLine("Enter your productname");
            string produt = Console.ReadLine();
            foreach(var i in list)
            {
                if(i.ProductName==produt)
                {
                    Console.WriteLine("ProductName :"+i.ProductName + ", price :" + i.Price + ", Quantity :" + i.Quantity);
                }
            }
        }
        public void QueryPrice()
        {
            Console.WriteLine("Enter your price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your operator");
            char op = Convert.ToChar(Console.ReadLine());
            foreach(var i in list)
            {
                if (i.Price > price && op=='>')
                {
                    Console.WriteLine("ProductName :" + i.ProductName + ", price :" + i.Price + ", Quantity :" + i.Quantity);
                }
                else if (i.Price< price && op=='<')
                {
                    Console.WriteLine("ProductName :" + i.ProductName + ", price :" + i.Price + ", Quantity :" + i.Quantity);
                }
                else if(i.Price==price)
                {
                    Console.WriteLine("ProductName :" + i.ProductName + ", price :" + i.Price + ", Quantity :" + i.Quantity);
                }
            }
        }
        
        }
    }

