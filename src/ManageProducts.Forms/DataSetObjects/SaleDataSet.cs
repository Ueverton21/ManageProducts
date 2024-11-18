using System;

namespace ManageProducts.Forms.Reports.DataSetObjects
{
    public class SaleDataSet
    {
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string PriceAll { get; set;  }
    }
}
