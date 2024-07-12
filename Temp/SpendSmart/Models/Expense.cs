using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        [Required]
        public string?  Description { get; set; }
    }
}
