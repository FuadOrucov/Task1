using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Addition
{
    public class Product
    {
        public Tv Tv { get; set; }
        public Laptop Laptop { get; set; }

        private static int counter = 1;
        private int id;
        private string barcode;
        private decimal purchasePrice;
        private decimal salePrice;
        private decimal discountPrice;
        private DateTime createDate;
        private string brand;
        private string model;
        private bool isDeleted;
        private DateTime deleteDate;
        private DateTime updateDate;

        private static int CounterId = 1;
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Barcode
        {
            get { return barcode; }

            set
            {
                if (!IsBarcode(value))
                {
                    Console.WriteLine("Bu barkod daha öncə başqa məhsul üçün sistemə əlavə olunub");
                }
                else
                {
                    barcode = value;
                }
            }

        }
        bool IsBarcode(string newBarcode)
        {
            return true;
        }



        public decimal PurchasePrice
        {
            get
            {
                return purchasePrice;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Alış qiyməti 0-dan kiçik ola bilməz");
                }
                else
                {
                    purchasePrice = value;
                }
            }
        }

        public decimal SalePrice
        {
            get
            {
                return salePrice;
            }
            set
            {
                if (value < purchasePrice)
                {
                    Console.WriteLine("Satış qiyməti alış qiymətindən kiçik ola bilməz");
                }
                else
                {
                    salePrice = value;
                }
            }
        }

        public decimal DiscountPrice
        {
            get
            {
                return discountPrice;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Endirimli qiyməti 0-dan kiçik ola bilməz");
                }
                else
                {
                    discountPrice = value;
                }
            }
        }

        public DateTime CreateData
        {
            get
            {
                return createDate;
            }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set
            {
                if (isDeleted != value)
                {
                    isDeleted = value;
                    if (isDeleted)
                    {
                        deleteDate = DateTime.Now;
                    }
                    else
                    {
                        deleteDate = DateTime.MinValue;
                    }
                }
            }
        }
        public DateTime DeleteDate { get { return deleteDate; } }
        public DateTime UpdateDate { get { return updateDate; } }


        public Product(string barcode, decimal purchasePrice, decimal salePrice, decimal discountPrice, string brand, string model)
        {
            id = CounterId++;
            Barcode = barcode;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            DiscountPrice = discountPrice;
            Brand = brand;
            Model = model;
            createDate = DateTime.Now;
            isDeleted = false;
            deleteDate = DateTime.Now;
            updateDate = DateTime.Now;

        }

    }
}
