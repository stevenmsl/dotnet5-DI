using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Loans;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly ILoan _loan;

        public LoansController(ILoan loan)
        {
            _loan = loan;
        }


        // GET: api/<LoansController>
        [HttpGet]

        public async Task<List<LoanModel>> Get()
        {
            return await _loan.GetLoans();
        }
       

        // POST api/<LoansController>
        [HttpPost]
        public async Task<LoanModel> Post([FromBody] LoanModel loan)
        {
            return await _loan.CreateLoan(loan.Amount, loan.Note);

        }

    }
}
