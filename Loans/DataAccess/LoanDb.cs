using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans

{
    public class LoanDb : IDb
    {

        private readonly List<LoanModel> loans = new();

        public LoanDb()
        {
            loans.Add(new() { Id = 1, Amount = 10.0m, Note = "high interest" });
            loans.Add(new() { Id = 2, Amount = 20.0m, Note = "credit line" });
        }

        public LoanModel CreateLoan(decimal amount, string note)
        {
            var nextId = loans.Max(tx => tx.Id) + 1;

            LoanModel tx = new() { Id = nextId, Amount = amount, Note = note };
            loans.Add(tx);

            return tx;

        }

        public List<LoanModel> GetLoans()
        {
            return loans.ToList();
        }
    }
}
