using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Addition
{
    public class Tv : Product
    {
        public Tv(string barcode, decimal purchasePrice, decimal salePrice, decimal discountPrice, string brand,
            string model, bool smartTV, decimal inch, bool hdmi) :
            base(barcode, purchasePrice, salePrice, discountPrice, brand, model)
        {
            SmartTV = smartTV;
            Inch = inch;
            HDMI = hdmi;
        }

        public bool SmartTV { get; set; }
        public decimal Inch { get; set; }
        public bool HDMI { get; set; }

    }
}
