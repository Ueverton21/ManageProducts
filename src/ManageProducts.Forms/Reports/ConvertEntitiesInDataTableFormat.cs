using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.Reports.DataSetObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace ManageProducts.Forms.Reports
{
    public class ConvertEntitiesInDataTableFormat
    {
        public DataTable GetClientsDataTable(List<Client> clients)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id",typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Address", typeof(string));

            foreach (var item in clients)
            {
                table.Rows.Add(item.Id,item.Name,item.Phone,item.Email,item.Address);
            }
            return table;
        }
        public DataTable GetProductsDataTable(List<Product> products)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Stock", typeof(string));

            foreach (var item in products)
            {
                table.Rows.Add(item.Id, item.Name, item.Description, item.Price, item.Stock);
            }
            return table;
        }

        public DataTable GetDataSetSalesDataTable(List<SaleDataSet> sales)
        {

            DataTable table = new DataTable();
            table.Columns.Add("SaleDate", typeof(DateTime));
            table.Columns.Add("ClientName", typeof(string));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("PriceAll", typeof(string));
            table.Columns.Add("Quantity", typeof(int));

            foreach (var item in sales)
            {
                table.Rows.Add(item.SaleDate, item.ClientName, 
                    item.ProductName, item.Price, item.PriceAll,item.Quantity);
            }
            return table;
        }
    }

}
