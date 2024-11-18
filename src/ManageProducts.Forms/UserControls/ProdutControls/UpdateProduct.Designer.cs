namespace ManageProducts.Forms.UserControls.ProdutControls
{
    partial class UpdateProduct
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Editar Produto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(183, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonConfirmClick);
            // 
            // TextStock
            // 
            this.TextStock.Location = new System.Drawing.Point(183, 260);
            this.TextStock.Name = "TextStock";
            this.TextStock.Size = new System.Drawing.Size(173, 20);
            this.TextStock.TabIndex = 36;
            this.TextStock.TextChanged += new System.EventHandler(this.TextStock_TextChanged);
            this.TextStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Estoque";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextPrice
            // 
            this.TextPrice.Location = new System.Drawing.Point(183, 205);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(173, 20);
            this.TextPrice.TabIndex = 34;
            this.TextPrice.TextChanged += new System.EventHandler(this.TextPrice_TextChanged);
            this.TextPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(180, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Preço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(183, 116);
            this.TextDescription.Multiline = true;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(173, 58);
            this.TextDescription.TabIndex = 32;
            this.TextDescription.TextChanged += new System.EventHandler(this.TextDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descrição";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(183, 69);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(173, 20);
            this.TextName.TabIndex = 30;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Size = new System.Drawing.Size(538, 358);
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label1;
    }
}
