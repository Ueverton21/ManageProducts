using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.ValidateForm;
using System;
using System.Text;
using System.Windows.Forms;

namespace ManageProducts.Forms.UserControls.ProductControls
{
    public partial class AddProduct : UserControl
    {
        private string NameProduct = string.Empty;
        private string DescriptionProduct = string.Empty;
        private string PriceProduct = string.Empty;
        private string StockProduct = string.Empty;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.NameProduct = TextName.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.PriceProduct = TextPrice.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.DescriptionProduct = TextDescription.Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            this.StockProduct = TextStock.Text;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ButtonConfirmClick(object sender, EventArgs e)
        {

            StringBuilder errors = ValidateFormProduct
                .ExecuteValidate(name: NameProduct,price: PriceProduct, stock: StockProduct);
            

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            DbHelper db = new DbHelper();
            var inserted = db.AddProduct(new Product()
            {
                Name = this.NameProduct,
                Description = this.DescriptionProduct,
                Price = Decimal.Parse(this.PriceProduct),
                Stock = Int32.Parse(this.StockProduct)
            });

            if (inserted)
            {
                MessageBox.Show("Produto criado: \n" + $"{this.NameProduct}");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao criar novo produto");
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

        private void ClearFields()
        {
            this.TextName.Text = string.Empty;
            this.TextPrice.Text = string.Empty;
            this.TextDescription.Text = string.Empty;
            this.TextStock.Text = string.Empty;
        }
    }
}
