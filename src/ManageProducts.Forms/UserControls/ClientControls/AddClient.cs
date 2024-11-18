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

namespace ManageProducts.Forms.UserControls.ClientControls
{
    public partial class AddClient : UserControl
    {
        private string ClientName = string.Empty;
        private string ClientAddress = string.Empty;
        private string ClientEmail = string.Empty;
        private string ClientPhone = string.Empty;
        public AddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextStock_TextChanged(object sender, EventArgs e)
        {
            ClientPhone = TextPhone.Text.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextPrice_TextChanged(object sender, EventArgs e)
        {
            ClientEmail = TextEmail.Text.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {
            ClientAddress = TextAddress.Text.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {
            ClientName = TextName.Text.ToString();
            
        }

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            StringBuilder errors = ValidateFormClient
                .ExecuteValidate(name: ClientName, address: ClientAddress, email: ClientEmail, phone: ClientPhone);

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            DbHelper db = new DbHelper();
            var inserted = db.AddClient(new Client()
            {
                Name = this.ClientName,
                Address = this.ClientAddress,
                Email = this.ClientEmail,
                Phone = this.ClientPhone
            });

            if (inserted)
            {
                MessageBox.Show("Client criado: \n" + $"{this.ClientName}");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao criar novo produto");
            }
        }

        private void ClearFields()
        {
            this.TextName.Text = string.Empty;
            this.TextAddress.Text = string.Empty;
            this.TextEmail.Text = string.Empty;
            this.TextPhone.Text = string.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
