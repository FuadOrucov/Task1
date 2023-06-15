using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_task
{
    public class Atm
    {
        private int balance = 1000;
        private string pin="5544";

        public void Result()
        {
            Console.WriteLine("ATM'e xos gelidiniz");
            Console.WriteLine("PIN-i daxil edin");
            pin =Console.ReadLine();
            Console.WriteLine("==============");
            if (IsValid(pin))
            {
                ShowMenu();
            }
            else 
            {
                
                Console.WriteLine("Daxil etdiyiniz sifre duzgun deyil. Zehmet olmasa sifrenizi yeniden daxil edin");
                
                Console.WriteLine();
                Console.WriteLine("ATM'e xos gelidiniz");
                Console.WriteLine("PIN-i daxil edin");
                pin = Console.ReadLine();
                Console.WriteLine("==============");
                ShowMenu();
            }
          

        }
      bool IsValid(string pin)
        {
            if (pin=="5544")
            {
                return true;
            }
            return false;
        }

        void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1.Balansa bax");
                Console.WriteLine("2.Nagd pul cixarmaq");
                Console.WriteLine("3.Hesabdan cixmaq");
                Console.WriteLine("================");
                Console.WriteLine("Emeliyyati secin: (1 ve 3 araliginda reqem daxil edin)");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        WithDrawCash();
                        break;
                    case "3":
                        Console.WriteLine("Hesabdn cixis etmek");
                        return;
                        break;
                    default:
                        Console.WriteLine("Yanlis emeliyyat secdiniz zehmet olmasa yeniden cehd edin");
                        break;
                }
            }
        }

        void CheckBalance()
        {
            Console.WriteLine("Balansiniz" + " " + balance +" " + "AZN'dir");
            Console.WriteLine("=============");
        }
        
       void WithDrawCash()
        {
            Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount>=1 &&amount<=1000 &&amount<=balance)
            {
                int money100 = amount / 100;
                int money50 = (amount % 100) / 50;
                int money20 = ((amount % 100) % 50) / 20;
                int money10 = (((amount % 100) % 50) % 20)/10;
                int money5 = ((((amount % 100) % 50) % 20)%10)/5;
                int money1 = (((((amount % 100) % 50) % 20)%10)%5)/1;

                Console.WriteLine("Cixarilan nagd mebleg" + " " + amount +" "+ "AZN");
                Console.WriteLine();
                Console.WriteLine("100 AZN:" + money100 + " " +"denedir");
                Console.WriteLine("50 AZN:" + money50 + " " + "denedir");
                Console.WriteLine("20 AZN:" + money20 + " " + "denedir");
                Console.WriteLine("10 AZN:" + money10 + " " + "denedir");
                Console.WriteLine("5 AZN:" + money5 + " " + "denedir");
                Console.WriteLine("1 AZN:" + money1 + " " + "denedir");
                Console.WriteLine();
                balance-= amount;
                Console.WriteLine("Sizin kartinizdan qalan mebleg" + " "+ balance + " " + "AZN'dir");
                Console.WriteLine("Tarix:" +DateTime.Now.ToString());
                Console.WriteLine("=============");

            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");

            }
           
        }
        
    }
    
}
