namespace RepetitionV10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxTimmar = new System.Windows.Forms.TextBox();
            this.tbxTimpenning = new System.Windows.Forms.TextBox();
            this.tbxFaktura = new System.Windows.Forms.TextBox();
            this.btnSkapaFaktura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRabatt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(104, 58);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 0;
            // 
            // tbxTimmar
            // 
            this.tbxTimmar.Location = new System.Drawing.Point(104, 119);
            this.tbxTimmar.Name = "tbxTimmar";
            this.tbxTimmar.Size = new System.Drawing.Size(100, 20);
            this.tbxTimmar.TabIndex = 1;
            // 
            // tbxTimpenning
            // 
            this.tbxTimpenning.Location = new System.Drawing.Point(104, 179);
            this.tbxTimpenning.Name = "tbxTimpenning";
            this.tbxTimpenning.Size = new System.Drawing.Size(100, 20);
            this.tbxTimpenning.TabIndex = 2;
            // 
            // tbxFaktura
            // 
            this.tbxFaktura.Location = new System.Drawing.Point(296, 58);
            this.tbxFaktura.Multiline = true;
            this.tbxFaktura.Name = "tbxFaktura";
            this.tbxFaktura.Size = new System.Drawing.Size(209, 375);
            this.tbxFaktura.TabIndex = 3;
            // 
            // btnSkapaFaktura
            // 
            this.btnSkapaFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkapaFaktura.Location = new System.Drawing.Point(47, 315);
            this.btnSkapaFaktura.Name = "btnSkapaFaktura";
            this.btnSkapaFaktura.Size = new System.Drawing.Size(194, 118);
            this.btnSkapaFaktura.TabIndex = 4;
            this.btnSkapaFaktura.Text = "Skapa faktura";
            this.btnSkapaFaktura.UseVisualStyleBackColor = true;
            this.btnSkapaFaktura.Click += new System.EventHandler(this.btnSkapaFaktura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arbetade timmar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Timpenning";
            // 
            // checkRabatt
            // 
            this.checkRabatt.AutoSize = true;
            this.checkRabatt.Location = new System.Drawing.Point(16, 235);
            this.checkRabatt.Name = "checkRabatt";
            this.checkRabatt.Size = new System.Drawing.Size(97, 17);
            this.checkRabatt.TabIndex = 8;
            this.checkRabatt.Text = "Rabatt (100 kr)";
            this.checkRabatt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(531, 456);
            this.Controls.Add(this.checkRabatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkapaFaktura);
            this.Controls.Add(this.tbxFaktura);
            this.Controls.Add(this.tbxTimpenning);
            this.Controls.Add(this.tbxTimmar);
            this.Controls.Add(this.tbxKund);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxTimmar;
        private System.Windows.Forms.TextBox tbxTimpenning;
        private System.Windows.Forms.TextBox tbxFaktura;
        private System.Windows.Forms.Button btnSkapaFaktura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkRabatt;
    }
}

