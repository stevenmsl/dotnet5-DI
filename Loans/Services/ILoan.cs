using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    public interface ILoan
    {
        Task<LoanModel> CreateLoan(decimal amount, string note);
        Task<List<LoanModel>> GetLoans();
    }
}
