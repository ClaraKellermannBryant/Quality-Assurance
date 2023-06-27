// This is implementation for a payroll system.
// The implementation is inspired by a tutorial from Microsoft here: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
// The implementation will use a unit test to show software deficiencies and threats to PII. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Unit_Test
{
    public class PayrollAccount
    {

        private readonly string p_employeeName;
        private readonly string p_companyName;
        private readonly string p_companyCode;

        private double p_compensation;
        private PayrollAccount() { }

        public PayrollAccount(string employeeName, string companyName, string companyCode, double compensation) // overload
        {
            this.p_employeeName = employeeName;
            this.p_companyName = companyName;
            this.p_companyCode = companyCode;
            this.p_compensation = compensation;
        }

        // Getters for payroll objects.
        public string EmployeeName { get { return p_employeeName; } }
        public string CompanyName { get { return p_companyName; } }
        public string CompanyCode { get { return p_companyCode; } }
        public double Compensation { get { return p_compensation; } }

        // Payments recieved and Benefits Associated
        public void Payment(double quota)
        {
           if (quota > p_compensation)
            {
                p_compensation = quota;
                throw new ArgumentOutOfRangeException("quota");
            }
            
            if (quota < 0)
            {
                throw new ArgumentOutOfRangeException("quota");
            }

            p_compensation *= quota; // Intentionally Wrong
        }

        public void Benefits (double quota)
        {
            if (quota <= p_compensation) // From test, fix the overload from the quota here.
            {
                throw new ArgumentOutOfRangeException("quota");
            }

            p_compensation /= quota; // Intentionally Wrong
        }

        static void Main(string[] args)
        {
            PayrollAccount pa = new PayrollAccount("Bob Aveline", "XYZ Consulting", "64517", 112.85);

            pa.Payment(56.42);
            pa.Benefits(26.45);

            Console.WriteLine("Current payment is ${0} and current benefits is ${1}", pa.Compensation);
        }
    }
}
