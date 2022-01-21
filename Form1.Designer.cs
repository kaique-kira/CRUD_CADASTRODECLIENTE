namespace Interface
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNOME = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTELEFONE = new System.Windows.Forms.Label();
            this.txtENDERECO = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(30, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNOME
            // 
            this.txtNOME.BackColor = System.Drawing.Color.DimGray;
            this.txtNOME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtNOME.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNOME.Location = new System.Drawing.Point(27, 70);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(114, 38);
            this.txtNOME.TabIndex = 2;
            this.txtNOME.Text = "Nome";
            this.txtNOME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 164);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(365, 38);
            this.textBox4.TabIndex = 9;
            // 
            // txtTELEFONE
            // 
            this.txtTELEFONE.BackColor = System.Drawing.Color.DimGray;
            this.txtTELEFONE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTELEFONE.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTELEFONE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTELEFONE.Location = new System.Drawing.Point(27, 117);
            this.txtTELEFONE.Name = "txtTELEFONE";
            this.txtTELEFONE.Size = new System.Drawing.Size(114, 38);
            this.txtTELEFONE.TabIndex = 10;
            this.txtTELEFONE.Text = "Telefone";
            this.txtTELEFONE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.BackColor = System.Drawing.Color.DimGray;
            this.txtENDERECO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtENDERECO.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENDERECO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtENDERECO.Location = new System.Drawing.Point(27, 164);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(114, 38);
            this.txtENDERECO.TabIndex = 11;
            this.txtENDERECO.Text = "Endereço";
            this.txtENDERECO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DimGray;
            this.txtID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtID.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(27, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 37);
            this.txtID.TabIndex = 12;
            this.txtID.Text = "Id";
            this.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 38);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 38);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(365, 37);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.BackColor = System.Drawing.Color.DimGray;
            this.txtEMAIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtEMAIL.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEMAIL.Location = new System.Drawing.Point(27, 211);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(114, 38);
            this.txtEMAIL.TabIndex = 17;
            this.txtEMAIL.Text = "E-mail";
            this.txtEMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 211);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(365, 38);
            this.textBox5.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(157, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(279, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(404, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 49);
            this.button4.TabIndex = 20;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 565);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtENDERECO);
            this.Controls.Add(this.txtTELEFONE);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Casatro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtNOME;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtTELEFONE;
        private System.Windows.Forms.Label txtENDERECO;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtEMAIL;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

