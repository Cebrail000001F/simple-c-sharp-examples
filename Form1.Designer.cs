
namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxArabalar = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(174, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "ButtonMesajYaz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.Khaki;
            this.textBoxMessage.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMessage.Location = new System.Drawing.Point(413, 182);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(291, 23);
            this.textBoxMessage.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "buttonDelete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxArabalar
            // 
            this.comboBoxArabalar.FormattingEnabled = true;
            this.comboBoxArabalar.Location = new System.Drawing.Point(469, 406);
            this.comboBoxArabalar.Name = "comboBoxArabalar";
            this.comboBoxArabalar.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArabalar.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 126);
            this.button3.TabIndex = 4;
            this.button3.Text = "buttonComboboxaYaz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "labelDegiş";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxArabalar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxArabalar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

