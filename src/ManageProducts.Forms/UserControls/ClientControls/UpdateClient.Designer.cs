namespace ManageProducts.Forms.UserControls.ClientControls
{
    partial class UpdateClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonConfirmClick);
            // 
            // TextPhone
            // 
            this.TextPhone.Location = new System.Drawing.Point(184, 238);
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(173, 20);
            this.TextPhone.TabIndex = 25;
            this.TextPhone.TextChanged += new System.EventHandler(this.TextPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefone";
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(184, 181);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(173, 20);
            this.TextEmail.TabIndex = 23;
            this.TextEmail.TextChanged += new System.EventHandler(this.TextEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(184, 124);
            this.TextAddress.Multiline = true;
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(173, 21);
            this.TextAddress.TabIndex = 21;
            this.TextAddress.TextChanged += new System.EventHandler(this.TextAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Endereço";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(184, 70);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(173, 20);
            this.TextName.TabIndex = 19;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Editar Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label1);
            this.NameClient = "UpdateClient";
            this.Size = new System.Drawing.Size(538, 358);
            this.Load += new System.EventHandler(this.UpdateClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
