using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace pt78
{
    [TestFixture()]
    public class UserProfileTest
    {
        [Test()] //*this test the status update method
        public void StatusUpdateCheck(){
            Transaction t1 = new Transaction(1, "01.03.06", 20000, Transaction.TransactionMode.Online);
            Transaction t2 = new Transaction(2, "01.03.06", 10000, Transaction.TransactionMode.Offline);

            UserProfile u1 = new UserProfile( 001, "Test", "999", 2018);

            u1.AddTransaction(t1);
            u1.AddTransaction(t2);

            u1.StatusUpdate();

            Assert.AreEqual(UserProfile.UserProfileStatus.Platinum,u1.Status);
        }
        [Test()]
        public void TransactionListCheck(){
            Transaction t1 = new Transaction(1, "01.03.06", 20000, Transaction.TransactionMode.Online);
            Transaction t2 = new Transaction(2, "01.03.06", 10000, Transaction.TransactionMode.Offline);

            UserProfile u1 = new UserProfile( 001, "Test", "999", 2018);

            u1.AddTransaction(t1);
            u1.AddTransaction(t2);

            Assert.AreEqual(2,u1.ListofTransactions());
            /* This test works by returning the number of transactions insde while also printing the values. In total i kept 2 
            transaction objects so it returns 2 */
        }

        [Test()] //*this test if the adding method works
        public void AddTransactionTest(){
            Transaction t1 = new Transaction(1, "01.03.06", 20000, Transaction.TransactionMode.Online);
            Transaction t2 = new Transaction(2, "01.03.06", 10000, Transaction.TransactionMode.Offline);
            Transaction t3 = new Transaction(3, "01.03.06", 2000, Transaction.TransactionMode.Online);

            UserProfile u1 = new UserProfile( 001, "Test", "999", 2018);

            u1.AddTransaction(t1);
            u1.AddTransaction(t2);
            u1.AddTransaction(t3);

            Assert.AreEqual(3,u1.ListofTransactions());

            /* This works by checking the number of added records and printing the values. I added 3 so it returns 3*/
        }

        [Test()]
        public void DeleteTransactionTest(){
            Transaction t1 = new Transaction(1, "01.03.06", 20000, Transaction.TransactionMode.Online);
            Transaction t2 = new Transaction(2, "01.03.06", 10000, Transaction.TransactionMode.Offline);
            Transaction t3 = new Transaction(3, "01.03.06", 2000, Transaction.TransactionMode.Online);

            UserProfile u1 = new UserProfile( 001, "Test", "999", 2018);

            u1.AddTransaction(t1);
            u1.AddTransaction(t2);
            u1.AddTransaction(t3);

            u1.DeleteTransaction(t3);

            Assert.AreEqual(2,u1.ListofTransactions());

            /*This works by adding 3 items in the list and then removing one. Since the other
            method returns the number of items in side the list it should only return 2  coz we deleted 1*/
        }

    }
}
