namespace ManageProducts.Forms
{
    partial class MainScreen
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Products = new System.Windows.Forms.ToolStripButton();
            this.Clients = new System.Windows.Forms.ToolStripButton();
            this.Sale = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Clients,
            this.Sale});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Products
            // 
            this.Products.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Products.Image = ((System.Drawing.Image)(resources.GetObject("Products.Image")));
            this.Products.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(59, 22);
            this.Products.Text = "Produtos";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Clients
            // 
            this.Clients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Clients.Image = ((System.Drawing.Image)(resources.GetObject("Clients.Image")));
            this.Clients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(53, 22);
            this.Clients.Text = "Clientes";
            this.Clients.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Sale
            // 
            this.Sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Sale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sale.Image = ((System.Drawing.Image)(resources.GetObject("Sale.Image")));
            this.Sale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(48, 22);
            this.Sale.Text = "Vendas";
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(12, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(538, 358);
            this.MainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(562, 381);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(578, 420);
            this.MinimumSize = new System.Drawing.Size(578, 420);
            this.Name = "MainScreen";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Clients;
        private System.Windows.Forms.ToolStripButton Products;
        private System.Windows.Forms.ToolStripButton Sale;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
    }
}

