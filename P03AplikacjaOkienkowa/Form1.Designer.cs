namespace P03AplikacjaOkienkowa
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
            this.btnPowitanie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPowitanie
            // 
            this.btnPowitanie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPowitanie.Location = new System.Drawing.Point(28, 37);
            this.btnPowitanie.Name = "btnPowitanie";
            this.btnPowitanie.Size = new System.Drawing.Size(118, 73);
            this.btnPowitanie.TabIndex = 0;
            this.btnPowitanie.Text = "button1";
            this.btnPowitanie.UseVisualStyleBackColor = false;
            this.btnPowitanie.Click += new System.EventHandler(this.btnPowitanie_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(188, 129);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 2;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(188, 170);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 3;
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.Location = new System.Drawing.Point(370, 49);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(75, 76);
            this.btnZakoncz.TabIndex = 4;
            this.btnZakoncz.Text = "button1";
            this.btnZakoncz.UseVisualStyleBackColor = true;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPowitanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowitanie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnZakoncz;
    }
}

