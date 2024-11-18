namespace ManageProducts.Forms.UserControls
{
    partial class ProductUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.PanelProduct = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.PanelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToAddRows = false;
            this.ProductsGridView.AllowUserToDeleteRows = false;
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Description,
            this.Price,
            this.Stock,
            this.Delete,
            this.UpdateIcon});
            this.ProductsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsGridView.Location = new System.Drawing.Point(34, 41);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.Size = new System.Drawing.Size(464, 261);
            this.ProductsGridView.TabIndex = 1;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
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
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 104.6954F;
            this.Description.HeaderText = "Descrição";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 104.6954F;
            this.Price.HeaderText = "Preço";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.FillWeight = 104.6954F;
            this.Stock.HeaderText = "Estoque";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 81.21828F;
            this.Delete.HeaderText = "   ";
            this.Delete.Image = global::ManageProducts.Forms.Properties.Resources.delete_icon;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 24;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 24;
            // 
            // Update
            // 
            this.UpdateIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.UpdateIcon.DefaultCellStyle = dataGridViewCellStyle4;
            this.UpdateIcon.HeaderText = "";
            this.UpdateIcon.Image = global::ManageProducts.Forms.Properties.Resources.update_icon;
            this.UpdateIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UpdateIcon.MinimumWidth = 24;
            this.UpdateIcon.Name = "Update";
            this.UpdateIcon.ReadOnly = true;
            this.UpdateIcon.Width = 24;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.Location = new System.Drawing.Point(127, 6);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(32, 24);
            this.ButtonAddProduct.TabIndex = 2;
            this.ButtonAddProduct.Text = "+";
            this.ButtonAddProduct.UseVisualStyleBackColor = false;
            this.ButtonAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelProduct
            // 
            this.PanelProduct.Controls.Add(this.label2);
            this.PanelProduct.Controls.Add(this.ButtonPrint);
            this.PanelProduct.Controls.Add(this.ButtonAddProduct);
            this.PanelProduct.Controls.Add(this.ProductsGridView);
            this.PanelProduct.Controls.Add(this.label1);
            this.PanelProduct.Location = new System.Drawing.Point(3, 3);
            this.PanelProduct.Name = "PanelProduct";
            this.PanelProduct.Size = new System.Drawing.Size(532, 352);
            this.PanelProduct.TabIndex = 3;
            this.PanelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProduct_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gerar relatório";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrint.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonPrint.Image = global::ManageProducts.Forms.Properties.Resources.print_icon;
            this.ButtonPrint.Location = new System.Drawing.Point(466, 6);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(32, 32);
            this.ButtonPrint.TabIndex = 8;
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PanelProduct);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(538, 358);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.PanelProduct.ResumeLayout(false);
            this.PanelProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Panel PanelProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn UpdateIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonPrint;
    }
}
