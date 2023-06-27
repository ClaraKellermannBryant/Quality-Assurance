using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Payroll_Unit_Test;

namespace PayrollUnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        private PayrollAccount PayrollAccount;
        

        [TestMethod]
        public void PaymentAmount_Balance()
        {
            double startingPayment = 56.42;
            double feeAmount = 4.88;
            double intendedBalance = startingPayment + feeAmount;

            PayrollAccount = new PayrollAccount("Bob Aveline", "XYZ Consulting", "64517", 112.85);

            PayrollAccount.Benefits(feeAmount);

            PayrollAccount.Payment(intendedBalance);

            Assert.AreEqual(intendedBalance, feeAmount, 0.032, "Account is not accurate");
        }
    }
}
