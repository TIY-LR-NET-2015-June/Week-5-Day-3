using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace Challenge
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void CheckingAbleToTransferFunds()
        {
            CheckingAccount ca = new CheckingAccount(1200);
            CheckingAccount ca2 = new CheckingAccount(0);
            ca.TransferMoney(ca2, 1000);

            Assert.AreEqual(200, ca.Balance);
            Assert.AreEqual(1000, ca2.Balance);
        }

        [TestMethod]
        public void SavingsAbleToTransferFunds()
        {
            SavingsAccount ca = new SavingsAccount(1200);
            SavingsAccount ca2 = new SavingsAccount(0);
            ca.TransferMoney(ca2, 1000);

            Assert.AreEqual(100, ca.Balance);
            Assert.AreEqual(1000, ca2.Balance);
        }

        [TestMethod]
        public void CheckingAbleToDeposit()
        {
            CheckingAccount ca = new CheckingAccount(0);
            ca.DepositMoney(1000);

            Assert.AreEqual(1000, ca.Balance);
        }

        [TestMethod]
        public void SavingsAbleToDeposit()
        {
            SavingsAccount ca = new SavingsAccount(0);
            ca.DepositMoney(1000);

            Assert.AreEqual(1000, ca.Balance);
        }

        [TestMethod]
        public void CheckingAbleToWithDraw()
        {
            CheckingAccount ca = new CheckingAccount(2000);
            ca.WithDrawMoney(1000);

            Assert.AreEqual(1000, ca.Balance);
        }

        [TestMethod]
        public void SavingsAbleToWithDraw()
        {
            SavingsAccount ca = new SavingsAccount(2000);
            ca.WithDrawMoney(1000);

            Assert.AreEqual(950, ca.Balance);
        }

        [TestMethod]
        public void CheckingAbleToOverDraw()
        {
            CheckingAccount ca = new CheckingAccount(100);
            bool result = ca.WithDrawMoney(1000);

            Assert.IsTrue(result);
            Assert.AreEqual(-900, ca.Balance);
        }

        [TestMethod]
        public void SavingsNotAllowedToOverDraw()
        {
            SavingsAccount ca = new SavingsAccount(100);
            bool result = ca.WithDrawMoney(1000);

            Assert.IsFalse(result);
            Assert.AreEqual(100, ca.Balance);
        }

    }
}
