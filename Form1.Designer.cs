
namespace c_sharp_form_ornegi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textboxyazısı = new System.Windows.Forms.Label();
            this.yazıyıLabeleEKle = new System.Windows.Forms.Button();
            this.girisYap = new System.Windows.Forms.Button();
            this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(33, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 29);
            this.textBox1.TabIndex = 2;
            // 
            // textboxyazısı
            // 
            this.textboxyazısı.AutoSize = true;
            this.textboxyazısı.Location = new System.Drawing.Point(42, 181);
            this.textboxyazısı.Name = "textboxyazısı";
            this.textboxyazısı.Size = new System.Drawing.Size(52, 21);
            this.textboxyazısı.TabIndex = 3;
            this.textboxyazısı.Text = "label3";
            // 
            // yazıyıLabeleEKle
            // 
            this.yazıyıLabeleEKle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yazıyıLabeleEKle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yazıyıLabeleEKle.Location = new System.Drawing.Point(116, 100);
            this.yazıyıLabeleEKle.Name = "yazıyıLabeleEKle";
            this.yazıyıLabeleEKle.Size = new System.Drawing.Size(92, 61);
            this.yazıyıLabeleEKle.TabIndex = 4;
            this.yazıyıLabeleEKle.Text = "button1";
            this.yazıyıLabeleEKle.UseVisualStyleBackColor = false;
            // 
            // girisYap
            // 
            this.girisYap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisYap.Location = new System.Drawing.Point(665, 316);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(131, 83);
            this.girisYap.TabIndex = 5;
            this.girisYap.Text = "Giris";
            this.girisYap.UseVisualStyleBackColor = true;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(568, 142);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(334, 29);
            this.textBoxKullanıcıAdı.TabIndex = 6;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(568, 251);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(334, 29);
            this.textBoxSifre.TabIndex = 7;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSonuc.Location = new System.Drawing.Point(616, 469);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(89, 37);
            this.labelSonuc.TabIndex = 8;
            this.labelSonuc.Text = "Sonuc";
            this.labelSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSonuc.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(616, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı Adını Girin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(640, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sifrenizi Girin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullanıcıAdı);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.yazıyıLabeleEKle);
            this.Controls.Add(this.textboxyazısı);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textboxyazısı;
        private System.Windows.Forms.Button yazıyıLabeleEKle;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

