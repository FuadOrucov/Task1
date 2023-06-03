
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();



            Laptop laptop = new Laptop("dwedwew", 500, 800, 600, "brand1", "model5", "cpu2", "16gb", "videocard1");
            //{

            //    Barcode = "gdsj15",
            //    PurchasePrice =500,
            //    SalePrice=800,
            //    DiscountPrice=600,
            //    Brand = "Brand1",
            //    Model ="Model5",
            //    Cpu="Cpu2",
            //    Ram ="16GB",
            //    VideoCard="VideoCard1"

            //};

            Tv tv = new Tv("dswsw", 1500, 2000, 1800, "brand8", "model9", true, 50, true);
            //{
            //    Barcode = "wuwj45",
            //    PurchasePrice = 1500,
            //    SalePrice = 2000,
            //    DiscountPrice = 1800,
            //    Brand = "Brand2",
            //    Model = "Model2",
            //    SmartTV = true,
            //    Inch = 50,
            //    HDMI = true
            //};

            db.Add(laptop);
            db.Add(tv);

            ArrayList listProduct = db.GetAll();
            foreach (Product product in listProduct)
            {


                Console.WriteLine($"ID: {product.Id}\nBrand: {product.Brand}\nModel: {product.Model}\nBarcode: {product.Barcode}\n" +
                    $"PurchasePrice: {product.PurchasePrice}\nSalePrice:{product.SalePrice}\nDiscountPrice:{product.DiscountPrice}\n" +
                    $"");

            }

            Console.WriteLine("------------------");


            db.Update(tv, "brand8", "model10", 1800, 2000, 1500, "dff");
            listProduct = db.GetAll();
            Console.WriteLine("update product");
            foreach (Product product in listProduct)
            {


                Console.WriteLine($"ID: {product.Id}\nBrand: {product.Brand}\nModel: {product.Model}\nBarcode: {product.Barcode}\n" +
                    $"PurchasePrice: {product.PurchasePrice}\nSalePrice:{product.SalePrice}\nDiscountPrice:{product.DiscountPrice}\n" +
                    $"");

            }

            Console.WriteLine("-------");
            db.Remove(laptop);
            listProduct = db.GetAll();
            Console.WriteLine("remove product");
            foreach (Product product in listProduct)
            {


                Console.WriteLine($"ID: {product.Id}\nBrand: {product.Brand}\nModel: {product.Model}\nBarcode: {product.Barcode}\n" +
                    $"PurchasePrice: {product.PurchasePrice}\nSalePrice:{product.SalePrice}\nDiscountPrice:{product.DiscountPrice}\n" +
                    $"");

            }

            //Console.WriteLine(  DateTime.MinValue);

            Console.ReadLine();

        }
    }
}
