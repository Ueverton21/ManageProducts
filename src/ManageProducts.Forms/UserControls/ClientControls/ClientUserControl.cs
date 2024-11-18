using ManageProducts.Forms.Data;
using ManageProducts.Forms.Entities;
using ManageProducts.Forms.Screens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManageProducts.Forms.UserControls.ClientControls
{
    public partial class ClientUserControl : UserControl
    {
        private List<Client> clients = new List<Client>();
        public ClientUserControl()
        {
            InitializeComponent();
            this.ClientsGridView.Columns["Delete"].DisplayIndex = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            PanelClient.Controls.Clear();

            AddClient addClient = new AddClient();

            addClient.Dock = DockStyle.Fill;

            PanelClient.Controls.Add(addClient);
        }

        private void PanelClient_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {
            DbHelper Db = new DbHelper();

            clients = Db.GetClients();

            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.DataSource = clients;

            ButtonPrint.Image = new Bitmap(Properties.Resources.print_icon, new Size(24, 24));
        }

        private void ClientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                var id = ClientsGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var name = ClientsGridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var phone = ClientsGridView.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                var email = ClientsGridView.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var address = ClientsGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                PanelClient.Controls.Clear();

                UpdateClient updateClient = new UpdateClient();
                updateClient.Id = id;
                updateClient.NameClient = name;
                updateClient.Phone = phone;
                updateClient.Email = email;
                updateClient.Address = address;

                updateClient.Dock = DockStyle.Fill;

                PanelClient.Controls.Add(updateClient);
            }

            if (e.ColumnIndex == 5)
            {
                var idValue = ClientsGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var result = MessageBox.Show("Deseja excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //Excluir produto do banco
                    DbHelper db = new DbHelper();

                    db.DeleteClient(Int32.Parse(idValue));

                    var clientList = (List<Client>)ClientsGridView.DataSource;

                    clientList.RemoveAt(e.RowIndex);

                    ClientsGridView.DataSource = null;
                    ClientsGridView.DataSource = clientList;
                }
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            using (var frm = new FormReport(clients))
            {
                frm.ShowDialog();
            }
        }
    }
}
