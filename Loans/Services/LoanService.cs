using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    public class LoanService : ILoan
    {
        private readonly IDb _db;

        public LoanService(IDb db)
        {
            _db = db;
        }

        public Task<LoanModel> CreateLoan(decimal amount, string note)
        {
            return Task.FromResult(_db.CreateLoan(amount, note));
        }

        public Task<List<LoanModel>> GetLoans()
        {
            return Task.FromResult(_db.GetLoans());
        }
    }
}
