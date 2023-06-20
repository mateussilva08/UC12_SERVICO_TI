namespace UC12_SERVICO_TI
{
    partial class Form1
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
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.textBoxCELULAR = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCELULAR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(221, 116);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(140, 20);
            this.textBoxNOME.TabIndex = 0;
            // 
            // textBoxENDERECO
            // 
            this.textBoxENDERECO.Location = new System.Drawing.Point(221, 302);
            this.textBoxENDERECO.Name = "textBoxENDERECO";
            this.textBoxENDERECO.Size = new System.Drawing.Size(140, 20);
            this.textBoxENDERECO.TabIndex = 1;
            // 
            // textBoxCELULAR
            // 
            this.textBoxCELULAR.Location = new System.Drawing.Point(221, 240);
            this.textBoxCELULAR.Name = "textBoxCELULAR";
            this.textBoxCELULAR.Size = new System.Drawing.Size(140, 20);
            this.textBoxCELULAR.TabIndex = 2;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(221, 179);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(140, 20);
            this.textBoxCPF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereço";
            // 
            // labelCELULAR
            // 
            this.labelCELULAR.AutoSize = true;
            this.labelCELULAR.Location = new System.Drawing.Point(163, 240);
            this.labelCELULAR.Name = "labelCELULAR";
            this.labelCELULAR.Size = new System.Drawing.Size(39, 13);
            this.labelCELULAR.TabIndex = 6;
            this.labelCELULAR.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "CADASTRO DE CLIENTES";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(252, 353);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 9;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 416);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCELULAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxCELULAR);
            this.Controls.Add(this.textBoxENDERECO);
            this.Controls.Add(this.textBoxNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.TextBox textBoxCELULAR;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCELULAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}

