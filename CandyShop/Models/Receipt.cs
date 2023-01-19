using CandyShop.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }
       
        public ApplicationUser Customer { get; set; }
        public DateTime ReceiptDate { get; set; }
        public double TotalCost { get; set; }
        public List <ReceiptItem> ReceiptItems { get; set; }

    }

    public class ReceiptItem
    {
        [Key]
        public string CandyName { get; set; }
        public double Price { get; set; }
        public Receipt Receipt { get; set; }
        public int ReceiptId { get; set; }


    }
}
