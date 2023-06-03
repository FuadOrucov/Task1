using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineShopping.Product;

namespace OnlineShopping
{
    public class Program
    {

        static void Main(string[] args)
        {

            Receipt receipt = new Receipt();
            Custumor custumor = new Custumor();
            custumor.AccountBalance = 450;
            Console.WriteLine(" Bravo Marketə Xoş gəlmisiniz!");
            Console.WriteLine("===============================");
            Console.WriteLine("         MƏHSUL MENYUSU");
            Console.WriteLine("===============================");
            Console.WriteLine();


            Console.WriteLine("1. Məhsul adı:Un || Qiyməti: 1 AZN");
            Console.WriteLine("2. Məhsul adı:Quzu əti || Qiyməti: 12 AZN");
            Console.WriteLine("3. Məhsul adı:Çay || Qiyməti: 1.5 AZN");
            Console.WriteLine("4. Məhsul adı:Qırmızı Alma || Qiyməti: 2.5 AZN");
            Console.WriteLine("5. Məhsul adı:Sarı Alma || Qiyməti: 2 AZN");
            Console.WriteLine("6. Məhsul adı:Lavaş || Qiyməti: 1.5 AZN");
            Console.WriteLine("7. Məhsul adı:Çörək || Qiyməti: 0.5 AZN");
            Console.WriteLine("8. Məhsul adı:Pomidor || Qiyməti: 2.5 AZN");
            Console.WriteLine("9. Məhsul adı:Xiyar || Qiyməti: 2 AZN");


            Console.Write("Seçiminizi edin: 1-9: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");

            string productName = " ";
            double productQuantity = 0;
            double prodcutPrice = 0;
            double productEdv = 0;
            bool productHasDiscount = false;
            switch (choice)
            {
                case 1:
                    productName = "Un";
                    productQuantity = 5;
                    prodcutPrice = 1;
                    productEdv = 0;
                    productHasDiscount = true;
                    break;
                case 2:
                    productName = "Quzu əti";
                    productQuantity = 3.5;
                    prodcutPrice = 12;
                    productEdv = 18;
                    productHasDiscount = false;
                    break;
                case 3:
                    productName = "Çay";
                    productQuantity = 2;
                    prodcutPrice = 1.50;
                    productEdv = 0;
                    productHasDiscount = false;
                    break;
                case 4:
                    productName = "Qırmızı Alma";
                    productQuantity = 2;
                    prodcutPrice = 2.50;
                    productEdv = 18;
                    productHasDiscount = false;
                    break;
                case 5:
                    productName = "Sarı Alma";
                    productQuantity = 2;
                    prodcutPrice = 2;
                    productEdv = 18;
                    productHasDiscount = true;
                    break;
                case 6:
                    productName = "Lavaş";
                    productQuantity = 1;
                    prodcutPrice = 2.50;
                    productEdv = 0;
                    productHasDiscount = false;
                    break;
                case 7:
                    productName = "Çörək";
                    productQuantity = 2;
                    prodcutPrice = 0.50;
                    productEdv = 18;
                    productHasDiscount = false;
                    break;
                case 8:
                    productName = "Pomidor";
                    productQuantity = 2;
                    prodcutPrice = 2.50;
                    productEdv = 0;
                    productHasDiscount = true;
                    break;
                case 9:
                    productName = "Xiyar";
                    productQuantity = 2;
                    prodcutPrice = 850;
                    productEdv = 0;
                    productHasDiscount = true;
                    break;


                default:
                    Console.WriteLine("Yanlış seçim");
                    return;
            }

            double totalPrice = 0; //umumi qiymet
            double profit = 0;     //qazanc
            double discount = 0;   //endirim
            double additioanlTax = 0; //əlavə vergi
            Product selectedProduct = new Product(productName, productQuantity, prodcutPrice, productEdv, productHasDiscount);
            double totalAmount = selectedProduct.CalculateTotal(); //umumi miqdar
            Console.WriteLine("Ödəniş növü: ");
            Console.WriteLine("1. Nəğd ödəniş");
            Console.WriteLine("2. Kartla ödəniş");
            Console.Write("Ödəniş növünün nömrəsini seçin: ");
            int paymentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("======================");
            if (totalAmount > 0)
            {
                totalPrice = selectedProduct.Quantity * selectedProduct.Price;
                discount = totalPrice * 0.02;
                profit = selectedProduct.CalculateProfit();

                additioanlTax = selectedProduct.CalculateTotal() * 0.18;
                double finalAmount = totalAmount + additioanlTax - discount;
                Console.WriteLine("Müştərinin hesabında 450 AZN pul var.");
                Console.WriteLine($"Məhsulun adı: {selectedProduct.Name}");
                Console.WriteLine($"Miqdar: {selectedProduct.Quantity} Kq");
                Console.WriteLine($"Qiyməti: {selectedProduct.Price} AZN");
                Console.WriteLine($"ƏDV: {selectedProduct.Edv} AZN");
                Console.WriteLine($"Toplam: {totalAmount} AZN");
                Console.WriteLine($"Endirim:{discount} AZN");
                Console.WriteLine($"Vergi(ƏDV):{additioanlTax} AZN");
                Console.WriteLine($"Qazanc: {profit} AZN");

                if (paymentNumber == 1)
                {
                    double cash_CashBack = additioanlTax * 0.1;
                    custumor.AccountBalance += cash_CashBack;
                    Console.WriteLine($"Ədv-dən müştərinin hesabına  qayıdan pul:{cash_CashBack} AZN");
                    Console.WriteLine("Ödəniş növü: Nəğd ödənilib");
                }
                else if (paymentNumber == 2)
                {
                    double cardCashBack = additioanlTax * 0.15;
                    Console.WriteLine($"Əlavə dəyər vergisi: {cardCashBack} AZN");
                    Console.WriteLine("Ödəniş növü: Kartla ödənilib");
                }

                Console.WriteLine($"Tarix:{DateTime.Now.ToString("HH:mm:ss")}");
                Console.WriteLine($"Qəbz nömrəsi:{receipt.Id}");


                if (selectedProduct.HasDiscount)
                {
                    Console.WriteLine($"Sizin qazancınız: {selectedProduct.CalculateProfit()} AZN");
                }
                if (finalAmount < 15)
                {
                    double deliveryFee = 4.50;
                    Console.WriteLine($"Alış-veriş məbləği 15 manatdan az olduğuna görə, çatdırılma ücün {deliveryFee} AZN əlavə olunacaq");
                    finalAmount += deliveryFee;
                }
                Console.WriteLine($"Yekun məbləğ: {finalAmount}AZN");
                if (finalAmount > custumor.AccountBalance)
                {
                    Console.WriteLine("Balansınızda kifayət qədər pul yoxdu");
                }
                else
                {
                    custumor.UpdateAccountBalance(-finalAmount);
                    Console.WriteLine($"Yeni hesab balansı:{custumor.AccountBalance} AZN");
                }

            }
            else
            {
                Console.WriteLine("Səhv ödəmə nömrəsi");

            }

            Console.ReadLine();


        }
    }
}
