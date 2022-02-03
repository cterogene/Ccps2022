using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Requisition
    {
        public long ReqId { get; set; }
        public decimal ReqAmount { get; set; }
        public string PayTo { get; set; } = null!;
        public string Justification { get; set; } = null!;
        public DateTime ReqDate { get; set; }
        public string? Memo { get; set; }
        public string? ApprovedBy { get; set; }
        public Guid UserId { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
