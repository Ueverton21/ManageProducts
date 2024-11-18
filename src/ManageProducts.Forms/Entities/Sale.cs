using System;

namespace ManageProducts.Forms.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }

        public string ClientName { get; set; }
        public string ProductName { get; set; }    
    }
}
