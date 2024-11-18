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
    public partial class UpdateClient : UserControl
    {
        public string Id;
        public string NameClient;
        public string Address;
        public string Phone;
        public string Email;
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            StringBuilder errors = ValidateFormClient
               .ExecuteValidate(name: NameClient, address: Address, email: Email, phone: Phone);


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            var client = new Client()
            {
                Id = Int32.Parse(Id),
                Name = NameClient,
                Address = Address,
                Phone = Phone,
                Email = Email
            };
            DbHelper db = new DbHelper();

            if (db.UpdateClient(client))
            {
                MessageBox.Show("Cliente editado!");
            }
            else
            {
                MessageBox.Show("Houve um erro ao editar o cliente.", "Erro");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            TextAddress.Text = Address;
            TextName.Text = NameClient;
            TextPhone.Text = Phone;
            TextEmail.Text = Email;
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {
            NameClient = TextName.Text;
        }

        private void TextAddress_TextChanged(object sender, EventArgs e)
        {
            Address = TextAddress.Text;
        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {
            Email = TextEmail.Text;
        }

        private void TextPhone_TextChanged(object sender, EventArgs e)
        {
            Phone = TextPhone.Text;
        }
    }
}
