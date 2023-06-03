using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    public class Product
    {
        public string Name { get; set; }
        public double Quantity { get; set; } // Miqdarı
        public double Price { get; set; }
        public double Edv { get; set; }
        public bool HasDiscount { get; set; } //Endirim var ya yox


        public Product(string name, double quantity, double price, double edv, bool hasDiscount)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Edv = edv;
            HasDiscount = hasDiscount;
        }

        public double CalculateTotal()
        {
            double total = Price * Quantity;
            double discount = HasDiscount ? total * 0.02 : 0;
            return total - discount;
        }

        public double CalculateProfit() //Sizin qazanciniz
        {
            double total = CalculateTotal();
            return total * 0.0885;
        }

        public class Receipt //Qəbz
        {


            public double Discount { get; set; }//Endirim
            public double TaxEdv { get; set; }//vergi ƏDV
            public double TotalAmount { get; set; }
            public double PaymentMethod { get; set; }

            public DateTime Date { get; set; }

            private int id;

            private static int CounterId = 1;
            public int Id
            {
                get
                {
                    return id;
                }
            }

            public Receipt()
            {
                id = CounterId++;

            }


        }
        public class Custumor
        {
            public double AccountBalance { get; set; }

            public void UpdateAccountBalance(double amount)
            {
                AccountBalance += amount;
            }
        }


    }
}
