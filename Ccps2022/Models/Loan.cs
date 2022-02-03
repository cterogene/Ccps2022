using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Loan
    {
        public long LoanId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Identification { get; set; }
        public string? Remarks { get; set; }
        public decimal Amount { get; set; }
    }
}
