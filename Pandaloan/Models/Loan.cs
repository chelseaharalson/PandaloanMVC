using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pandaloan.Models
{
    public class Loan
    {
        public int loanID { get; set; }
        public int borrowerID { get; set; }
        public int lenderID { get; set; }
        public double loanAmount { get; set; }
        public DateTime loanDate { get; set; }
        public int loanPeriod { get; set; }
        public double interestRate { get; set; }
        public int creditScore { get; set; }
        public string loanComment { get; set; }
    }
}