using DomainLayer.Models.DomainLayer.Models;

namespace DomainLayer.Models
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string PurchasesProduct { get; set; }
        public string PaymentType { get; set; }
    }
}
