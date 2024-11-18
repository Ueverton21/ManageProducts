using ManageProducts.Forms.Entities;
using ManageProducts.Forms.Reports;
using ManageProducts.Forms.Reports.DataSetObjects;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ManageProducts.Forms.Screens
{
    public partial class FormReport : Form
    {
        /*Terão 3 construtores diferentes, um para cada tipo de relátório
         Isso vai evitar ter que criar vários formulários específicos.
        Só fiz isso dessa forma pelo fato dos relatórios conter apenas
        um DataSet, sendo possível utilizar exatamente o mesmo código
        para configuração.
         */

        public FormReport(List<Product> products)
        {
            InitializeComponent();
            this.Text = "Relatório de Produtos";
            this.ReportViewer.LocalReport.DisplayName = "Relatório de Produtos";
            ConvertEntitiesInDataTableFormat convert = new ConvertEntitiesInDataTableFormat();

            var table = convert.GetProductsDataTable(products);
            FormReportEspecific(table, "Reports\\Templates\\products_report.rdlc");
        }
        public FormReport(List<Client> clients)
        {
            InitializeComponent();
            this.Text = "Relatório de Clientes";
            this.ReportViewer.LocalReport.DisplayName = "Relatório de Clientes";
            ConvertEntitiesInDataTableFormat convert = new ConvertEntitiesInDataTableFormat();

            var table = convert.GetClientsDataTable(clients);
            FormReportEspecific(table, "Reports\\Templates\\clients_report.rdlc");
        }
        public FormReport(List<SaleDataSet> sales)
        {
            InitializeComponent();
            this.Text = "Relatório de Vendas";
            this.ReportViewer.LocalReport.DisplayName = "Relatório de Vendas";
            ConvertEntitiesInDataTableFormat convert = new ConvertEntitiesInDataTableFormat();

            var table = convert.GetDataSetSalesDataTable(sales);
            FormReportEspecific(table, "Reports\\Templates\\sales_report.rdlc");
        }
        private void FormReportEspecific(DataTable table, string path)
        {
            try
            {

                string reportPath = Path.Combine(Application.StartupPath, path);
                this.ReportViewer.LocalReport.ReportPath = reportPath;
                this.ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", table));

                this.ReportViewer.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o relatório: {ex.Message}");
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }
    }
}
