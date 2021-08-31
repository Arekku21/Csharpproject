using System;
using SplashKitSDK;

namespace pt78
{
    public class Program
    {
        /*static void Show(Transaction[] tarray){
            foreach (Transaction item in tarray)
            {
                Console.Write("\nTransaction No: " + item.TransNo + "\n");
                Console.WriteLine("Transaction Date: " + item.Date);
                Console.WriteLine("TRansaction Amount(s): " + item.Amounts);
                Console.WriteLine("Points " + item.Points);
                Console.WriteLine("Transaction mode: " + item.Mode);
                Console.WriteLine(item.PrintInfo());
            }
        }*/
        static void Main(string[] args){
            Transaction t1 = new Transaction(1, "01.03.06", 20000, Transaction.TransactionMode.Online);
            Transaction t2 = new Transaction(2, "01.03.06", 10000, Transaction.TransactionMode.Offline);

            UserProfile u1 = new UserProfile( 001, "Test", "999", 2016);
            
            u1.AddTransaction(t1);
            u1.AddTransaction(t2);
            u1.StatusUpdate();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\nUser ID: " + u1.ID);
            Console.WriteLine("User Name: " + u1.Name);
            Console.WriteLine("User Contact NO: " + u1.Contactno);
            Console.WriteLine("User joined Year: " + u1.Year);
            Console.WriteLine("User MemberShip : " + u1.Status);
            Console.WriteLine("List of Transactions: ");
            Console.WriteLine("\nNo. of transactions: " + u1.ListofTransactions());
            Console.WriteLine("------------------------------------------------");

        }
    }
}

