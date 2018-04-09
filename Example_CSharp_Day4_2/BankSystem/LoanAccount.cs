using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is IndividualCustomer)
                return base.CalculateInterest(months - 3);

            if (this.Customer is CompanyCustomer)
                return base.CalculateInterest(months - 2);

            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return base.ToString("Loan Account");
        }
    }
}
