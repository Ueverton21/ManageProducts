using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.ValidateForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProducts.Forms.UserControls.ProdutControls
{
    public partial class UpdateProduct : UserControl
    {
        public string Id;
        public string NameProduct;
        public string Description;
        public string Price;
        public string Stock;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            StringBuilder errors = ValidateFormProduct
                .ExecuteValidate(name: NameProduct, price: Price, stock: Stock);


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            DbHelper db = new DbHelper();
            var updated = db.UpdateProduct(new Product()
            {
                Id = Int32.Parse(this.Id),
                Name = this.NameProduct,
                Description = this.Description,
                Price = Decimal.Parse(this.Price),
                Stock = Int32.Parse(this.Stock)
            });

            if (updated)
            {
                MessageBox.Show("Produto Editado!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao editar o produto");
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {
            NameProduct = TextName.Text;
        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {
            Description = TextDescription.Text;
        }

        private void TextPrice_TextChanged(object sender, EventArgs e)
        {
            Price =TextPrice.Text;
        }

        private void TextStock_TextChanged(object sender, EventArgs e)
        {
            Stock = TextStock.Text;
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            TextStock.Text = Stock;
            TextPrice.Text = Price;
            TextName.Text = NameProduct;
            TextDescription.Text = Description;
        }

        private void TextPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impedir letras e permitir apenas uma vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == ',' && TextPrice.Text.Contains(","))
                {
                    e.Handled = true; // Cancela o evento se já houver uma vírgula no TextBox
                }
            }

            // Permite apenas dois dígitos após a vírgula
            if (TextPrice.Text.Contains(","))
            {
                int index = TextPrice.Text.IndexOf(",");

                // Se o número de caracteres após a vírgula for 2, cancela a entrada de novos caracteres
                if (TextPrice.SelectionStart > index && TextPrice.Text.Length - index > 2 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void TextStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impedir digitação de letras
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
