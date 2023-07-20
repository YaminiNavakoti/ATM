using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public partial class Account
    {
       
        public void Savings()
        {
            Console.WriteLine("Savings Account");         
                calc();
        
        }
        public void Current()
        {
            Console.WriteLine("Current Account");

            calc();

        }

        public void ChildCare()
        {
            Console.WriteLine("ChildCare Account");

            calc();
         

        }

        public int count = 0;
        public void calc()
        {
            count++;

            if (count <=  3)
            {

                if (atm_option == "yes")
                {
                    int c;
                    int credit, debit;

                    Console.WriteLine("Select : \n 1.Credit \n 2.Withdrawal");
                    c = Convert.ToInt32(Console.ReadLine());

                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Enter transaction amount: ");
                            credit = Convert.ToInt32(Console.ReadLine());
                            balance += credit;
                            Console.WriteLine("Total Balance in Account: " + (balance));
                            break;

                        case 2:
                            Console.WriteLine("Enter transaction amount: ");
                            debit = Convert.ToInt32(Console.ReadLine());
                            balance -= debit;
                            Console.WriteLine("Total Balance in Account: " + (balance));
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Transactions cannot be performed!!!");
                }
            }
            else
            {
                balance -= 500;
                Console.WriteLine("\n \n __________Transaction limit exceeded__________");
                Console.WriteLine("Reamaining balanace : " + balance);
                throw new AException();
            }

         
        }
    }

    class AException : Exception
    {
        Account a = new Account();
        public AException()
        {
            Console.WriteLine("_________Rs 500 deducted from your account_________");
           
        }
    }
}


   

