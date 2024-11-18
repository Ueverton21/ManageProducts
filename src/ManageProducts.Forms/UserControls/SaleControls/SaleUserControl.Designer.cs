namespace ManageProducts.Forms.UserControls.SaleControls
{
    partial class SaleUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextCount = new System.Windows.Forms.TextBox();
            this.SelectClients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ButtonPrint);
            this.panel1.Controls.Add(this.SalesGridView);
            this.panel1.Controls.Add(this.ButtonConfirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextCount);
            this.panel1.Controls.Add(this.SelectClients);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SelectProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 352);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SalesGridView
            // 
            this.SalesGridView.AllowUserToAddRows = false;
            this.SalesGridView.AllowUserToDeleteRows = false;
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SalesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cliente,
            this.Produto,
            this.Quantidade,
            this.DataVenda});
            this.SalesGridView.Location = new System.Drawing.Point(28, 114);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.ReadOnly = true;
            this.SalesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesGridView.Size = new System.Drawing.Size(468, 217);
            this.SalesGridView.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ClientName";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "ProductName";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantity";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "SaleDate";
            this.DataVenda.HeaderText = "Data da Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConfirm.FlatAppearance.BorderSize = 0;
            this.ButtonConfirm.Image = global::ManageProducts.Forms.Properties.Resources.confirm_icon;
            this.ButtonConfirm.Location = new System.Drawing.Point(421, 75);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfirm.TabIndex = 6;
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirmClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // TextCount
            // 
            this.TextCount.Location = new System.Drawing.Point(336, 76);
            this.TextCount.Name = "TextCount";
            this.TextCount.Size = new System.Drawing.Size(79, 20);
            this.TextCount.TabIndex = 4;
            this.TextCount.TextChanged += new System.EventHandler(this.TextCount_TextChanged);
            this.TextCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCount_KeyPress);
            // 
            // SelectClients
            // 
            this.SelectClients.FormattingEnabled = true;
            this.SelectClients.Location = new System.Drawing.Point(187, 76);
            this.SelectClients.Name = "SelectClients";
            this.SelectClients.Size = new System.Drawing.Size(131, 21);
            this.SelectClients.TabIndex = 3;
            this.SelectClients.Text = "Selecione o Cliente";
            this.SelectClients.SelectedIndexChanged += new System.EventHandler(this.SelectClients_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registre uma nova venda abaixo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectProducts
            // 
            this.SelectProducts.FormattingEnabled = true;
            this.SelectProducts.Location = new System.Drawing.Point(28, 76);
            this.SelectProducts.Name = "SelectProducts";
            this.SelectProducts.Size = new System.Drawing.Size(145, 21);
            this.SelectProducts.TabIndex = 1;
            this.SelectProducts.Text = "Selecione o Produto";
            this.SelectProducts.SelectedIndexChanged += new System.EventHandler(this.SelectProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gerar relatório";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrint.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonPrint.Image = global::ManageProducts.Forms.Properties.Resources.print_icon;
            this.ButtonPrint.Location = new System.Drawing.Point(464, 16);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(32, 32);
            this.ButtonPrint.TabIndex = 10;
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // SaleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Name = "SaleUserControl";
            this.Size = new System.Drawing.Size(538, 358);
            this.Load += new System.EventHandler(this.SaleUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextCount;
        private System.Windows.Forms.ComboBox SelectClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonPrint;
    }
}
