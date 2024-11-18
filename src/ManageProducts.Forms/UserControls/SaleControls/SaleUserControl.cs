using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.Reports.DataSetObjects;
using ManageProducts.Forms.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProducts.Forms.UserControls.SaleControls
{
    public partial class SaleUserControl : UserControl
    {
        private string ClientId = "0";
        private string ProductId = "0";
        private string Count = "0";
        private List<Product> Products = new List<Product>();
        private List<Client> Clients = new List<Client>();
        private List<Sale> sales = new List<Sale>();
        public SaleUserControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SaleUserControl_Load(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();

            Products = db.GetProducts();
            Clients = db.GetClients();

            Products.Insert(0, new Product { Id = 0, Name = "-- Selecione um produto --" });
            Clients.Insert(0, new Client { Id = 0, Name = "-- Selecione um cliente --" });

            SelectProducts.DataSource = Products.OrderBy(p => p.Name).ToList();
            SelectProducts.DisplayMember = "Name";
            SelectProducts.ValueMember = "Id";

            SelectClients.DataSource = Clients.OrderBy(c => c.Name).ToList();
            SelectClients.DisplayMember = "Name";
            SelectClients.ValueMember = "Id";

            //Alterar tamanho dos ícones
            ButtonConfirm.Image = new Bitmap(Properties.Resources.confirm_icon, new Size(14, 14));
            ButtonPrint.Image = new Bitmap(Properties.Resources.print_icon, new Size(24, 24));
            
            //Buscar vendas
            sales = db.GetSales();
            foreach(var sale in sales)
            {
                sale.ProductName = Products.FirstOrDefault(p => p.Id ==  sale.ProductId).Name;
                sale.ClientName = Clients.FirstOrDefault(c => c.Id == sale.ClientId).Name;
            }

            SalesGridView.AutoGenerateColumns = false;
            SalesGridView.DataSource = sales;
        }

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if(ProductId == "0" || ProductId== "ManageProducts.Forms.Entities.Product")
            {
                errors.Append("Selecione um produto.\n");
            }
            if (ClientId == "0" || ClientId == "ManageProducts.Forms.Entities.Client")
            {
                errors.Append("Selecione um Cliente.\n");
            }
            //Caso venha vazio, setar valor zero para conversão
            Count = string.IsNullOrWhiteSpace(Count) ? "0" : Count;
            if (Int32.Parse(Count) == 0)
            {
                errors.Append("A quantidade tem que ser maior que zero.\n");
            }
            if(errors.Length > 0)
            {
                MessageBox.Show(
                errors.ToString(),
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            DbHelper db = new DbHelper();
            var sale = new Sale
            {
                ClientId = Int32.Parse(ClientId),
                ProductId = Int32.Parse(ProductId),
                Quantity = Int32.Parse(Count),
                SaleDate = DateTime.Now,
            };

            var inserted = db.AddSale(sale);

            if (inserted)
            {
                //Pegar Nome do produto e do cliente
                sale.ProductName = Products.FirstOrDefault(p => p.Id == sale.ProductId).Name;
                sale.ClientName = Clients.FirstOrDefault(c => c.Id == sale.ClientId).Name;

                //Atualizar lista(GridView)
                var productList = (List<Sale>)SalesGridView.DataSource;
                productList.Add(sale);
                SalesGridView.AutoGenerateColumns = false;
                SalesGridView.DataSource = null;
                SalesGridView.DataSource = productList;

                MessageBox.Show($"Venda registrada!");
            }
            else
            {
                MessageBox.Show(
                "Ocorreu um erro ao registrar venda",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            
        }

        private void TextCount_TextChanged(object sender, EventArgs e)
        {
            this.Count = TextCount.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectProducts.SelectedItem != null)
            {
                this.ProductId = SelectProducts.SelectedValue.ToString();
            }

        }

        private void SelectClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectClients.SelectedItem != null) {
                this.ClientId = SelectClients.SelectedValue.ToString();
            }
        }

        private void TextCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impedir digitação de letras
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            //Configurar objeto sale para o dataset
            List<SaleDataSet> salesDataSet = new List<SaleDataSet>();
            foreach(var sale in sales)
            {
                var product = Products.FirstOrDefault(p => p.Id == sale.ProductId);
                salesDataSet.Add(new SaleDataSet
                {
                    ClientName = sale.ClientName,
                    Quantity = sale.Quantity,
                    Price = Products.FirstOrDefault(p => p.Id == sale.ProductId).Price.ToString("F"),
                    PriceAll = (product.Price * sale.Quantity).ToString("F"),
                    ProductName = product.Name,
                    SaleDate = sale.SaleDate
                });
            }
            using (var frm = new FormReport(salesDataSet))
            {
                frm.ShowDialog();
            }
        }
    }
}
