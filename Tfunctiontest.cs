using System;
using SplashKitSDK;
using NUnit.Framework;

namespace pt78
{
    [TestFixture()]
   public class Tfunctiontest
   {
       [Test()] //Checking if the transaction type method works
       public void TestTransactionType(){
           Transaction test1 = new Transaction(1,"01.03.06",10, Transaction.TransactionMode.Online);


           Assert.AreEqual("That's a wise choice with more rewards", test1.PrintInfo());
       }
 
       [Test()] //Checking if the transaction for calculating the points works
        public void TestPointsCalculation(){
            Transaction test2 = new Transaction(1,"01.03.06",10,Transaction.TransactionMode.Online);
            test2.UpdatePoints();

            Assert.AreEqual(1,test2.Points);
        }
   } 
}