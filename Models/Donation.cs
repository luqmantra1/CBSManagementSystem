using System.ComponentModel.DataAnnotations;

namespace CBSManagementSystem.Models
{
    public class Donation
    {
        [Key]
        public int ItemID { get; set; }

        public string DonorName { get; set; }

        public string PhoneNo { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public decimal Price { get; set; }
    }
}
