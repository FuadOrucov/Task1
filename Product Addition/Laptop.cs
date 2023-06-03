using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Addition
{
    public class Laptop : Product
    {
        public Laptop(string barcode, decimal purchasePrice, decimal salePrice, decimal discountPrice, string brand, string model,
            string cpu, string ram, string videocard) :
            base(barcode, purchasePrice, salePrice, discountPrice, brand, model)
        {
            Cpu = cpu;
            Ram = ram;
            VideoCard = videocard;
        }

        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string VideoCard { get; set; }
    }
}
