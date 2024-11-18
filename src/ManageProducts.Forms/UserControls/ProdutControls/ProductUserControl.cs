using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.Screens;
using ManageProducts.Forms.UserControls.ClientControls;
using ManageProducts.Forms.UserControls.ProductControls;
using ManageProducts.Forms.UserControls.ProdutControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManageProducts.Forms.UserControls
{
    public partial class ProductUserControl : UserControl
    {
        private List<Product> products;
        public ProductUserControl()
        {
            InitializeComponent();
            DbHelper db = new DbHelper();

            products = db.GetProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelProduct.Controls.Clear();

            AddProduct addProduct = new AddProduct();

            addProduct.Dock = DockStyle.Fill;

            PanelProduct.Controls.Add(addProduct);
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

            this.ProductsGridView.AutoGenerateColumns = false;
            this.ProductsGridView.DataSource = products;

            ButtonPrint.Image = new Bitmap(Properties.Resources.print_icon, new Size(24, 24));
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var id = ProductsGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var name = ProductsGridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var description = ProductsGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                var price = ProductsGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                var stock = ProductsGridView.Rows[e.RowIndex].Cells["Stock"].Value.ToString();

                PanelProduct.Controls.Clear();

                UpdateProduct updateProduct = new UpdateProduct();
                updateProduct.Id = id;
                updateProduct.NameProduct = name;
                updateProduct.Description = description;
                updateProduct.Stock = stock;
                updateProduct.Price = price;

                updateProduct.Dock = DockStyle.Fill;

                PanelProduct.Controls.Add(updateProduct);
            }

            if (e.ColumnIndex == 5) {
                var idValue = ProductsGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var result = MessageBox.Show("Deseja excluir esse produto?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    //Excluir produto do banco
                    DbHelper db = new DbHelper();

                    db.DeleteProduct(Int32.Parse(idValue));

                    //Remover item da lista
                    // Obtém a lista original de objetos da fonte de dados
                    var productList = (List<Product>)ProductsGridView.DataSource;

                    // Remove o item da lista com base no índice da linha
                    productList.RemoveAt(e.RowIndex);

                    // Atualiza a DataGridView após a remoção
                    ProductsGridView.DataSource = null;
                    ProductsGridView.DataSource = productList;
                }
            }
            
        }

        private void PanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            using (var frm = new FormReport(products))
            {
                frm.ShowDialog();
            }
        }
    }
}
