using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Account a = new atm.Account();
            string choice;

            Console.WriteLine("Enter Customer Name:");
            a.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Customer Address:");
            a.CustomerAddr = Console.ReadLine();

            Console.WriteLine("Enter Balance:");
            a.Balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to enable ATM option? (yes/no)");
            a.HasATMOption = Console.ReadLine();

            do
            {
                Console.WriteLine("Select Account Type : ");
                Console.WriteLine("1.Savings \n 2.Current \n 3.ChildCare");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        a.Savings();
                        break;

                    case 2:
                        a.Current();
                        break;

                    case 3:
                        a.ChildCare();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }

                Console.WriteLine("Do you want to continue?...(y/n) : ");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "Y");

            

        }


    }


}
