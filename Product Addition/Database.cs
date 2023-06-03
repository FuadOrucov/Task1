using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Addition
{
    public class Database
    {

        private List<Product> products;
        public Database()
        {
            products = new List<Product>();

        }

        public void Add(Product product)
        {
            bool barcodeExists = products.Exists(p => p.Barcode == product.Barcode);
            if (barcodeExists)
            {
                Console.WriteLine("Bu barkod daha öncə başqa məhsul üçün sistemə əlavə olunub");

            }
            else
            {
                products.Add(product);
            }
        }

        public void Remove(Product product)
        {
            if (products.Contains(product))
            {
                product.IsDeleted = true;

            }
        }


        public ArrayList GetAll()
        {
            ArrayList newProductList = new ArrayList();
            foreach (Product item in products)
            {
                if (!item.IsDeleted)
                {
                    newProductList.Add(item);
                }
            }
            return newProductList;
        }


        public void Update(Product product, string brand, string model, decimal discountPrice, decimal salePrice,
            decimal purchasePrice, string barcode)
        {
            product.Brand = brand;
            product.Model = model;
            product.DiscountPrice = discountPrice;
            product.SalePrice = salePrice;
            product.PurchasePrice = purchasePrice;
            product.Barcode = barcode;

        }
    }
}
