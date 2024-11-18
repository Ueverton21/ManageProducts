namespace ManageProducts.Forms.UserControls.ClientControls
{
    partial class ClientUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelClient = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelClient
            // 
            this.PanelClient.Controls.Add(this.label2);
            this.PanelClient.Controls.Add(this.ButtonPrint);
            this.PanelClient.Controls.Add(this.ClientsGridView);
            this.PanelClient.Controls.Add(this.ButtonAddClient);
            this.PanelClient.Controls.Add(this.label1);
            this.PanelClient.Location = new System.Drawing.Point(4, 4);
            this.PanelClient.Name = "PanelClient";
            this.PanelClient.Size = new System.Drawing.Size(531, 351);
            this.PanelClient.TabIndex = 0;
            this.PanelClient.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelClient_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gerar relatório";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrint.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonPrint.Image = global::ManageProducts.Forms.Properties.Resources.print_icon;
            this.ButtonPrint.Location = new System.Drawing.Point(467, 8);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(32, 32);
            this.ButtonPrint.TabIndex = 6;
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AllowUserToAddRows = false;
            this.ClientsGridView.AllowUserToDeleteRows = false;
            this.ClientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClientsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Email,
            this.Address,
            this.Phone,
            this.Delete,
            this.Edit});
            this.ClientsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsGridView.Location = new System.Drawing.Point(35, 49);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.Size = new System.Drawing.Size(464, 261);
            this.ClientsGridView.TabIndex = 1;
            this.ClientsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Name";
            this.Nome.FillWeight = 104.6954F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 104.6954F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 104.6954F;
            this.Address.HeaderText = "Endereço";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 104.6954F;
            this.Phone.HeaderText = "Telefone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 81.21828F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::ManageProducts.Forms.Properties.Resources.delete_icon;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 24;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 24;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::ManageProducts.Forms.Properties.Resources.update_icon;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 24;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 24;
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddClient.ForeColor = System.Drawing.Color.White;
            this.ButtonAddClient.Location = new System.Drawing.Point(120, 12);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(32, 24);
            this.ButtonAddClient.TabIndex = 5;
            this.ButtonAddClient.Text = "+";
            this.ButtonAddClient.UseVisualStyleBackColor = false;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.FillWeight = 81.21828F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ManageProducts.Forms.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 24;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ManageProducts.Forms.Properties.Resources.update_icon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 24;
            // 
            // ClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PanelClient);
            this.Name = "ClientUserControl";
            this.Size = new System.Drawing.Size(538, 358);
            this.Load += new System.EventHandler(this.ClientUserControl_Load);
            this.PanelClient.ResumeLayout(false);
            this.PanelClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelClient;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}
