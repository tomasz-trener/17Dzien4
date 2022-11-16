namespace P06AplikacjaZawodnicy
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
            this.lblDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDane
            // 
            this.lblDane.FormattingEnabled = true;
            this.lblDane.Location = new System.Drawing.Point(12, 109);
            this.lblDane.Name = "lblDane";
            this.lblDane.Size = new System.Drawing.Size(329, 238);
            this.lblDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(89, 84);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(107, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(234, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(107, 76);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(234, 20);
            this.txtKraj.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kraj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lblDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

