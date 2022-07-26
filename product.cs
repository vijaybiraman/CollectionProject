using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryproject
{
    public class product
    {
        private string productname;
        private double price;
        private int quantity;
        private double total;
        public string ProductName
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
        public double Total
        {
            get;
            set;
        }

        public product()
        {

        }

        public product(string productname, double price, int quantity)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format($"productname : {productname}, price : {price}, Quantity : {quantity}");
        }
    }
}
