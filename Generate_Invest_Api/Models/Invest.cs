using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Generate_Invest_Api.Models
{
    public partial class Invest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string ProfilePic { get; set; }
        public decimal? TotalInvestment { get; set; }
    }
}
