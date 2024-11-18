using ManageProducts.Forms.UserControls;
using ManageProducts.Forms.UserControls.ClientControls;
using ManageProducts.Forms.UserControls.SaleControls;
using System;
using System.Windows.Forms;

namespace ManageProducts.Forms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            ClientUserControl client = new ClientUserControl();

            client.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(client);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            ProductUserControl productUserControl = new ProductUserControl();

            productUserControl.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(productUserControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sale_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            SaleUserControl sale = new SaleUserControl();

            sale.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(sale);
        }
    }
}
