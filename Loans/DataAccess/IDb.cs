using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    public interface IDb
    {

        List<LoanModel> GetLoans();
        LoanModel CreateLoan(decimal amount, string note);
    }
}
