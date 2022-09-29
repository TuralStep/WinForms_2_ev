namespace WinForms_2
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
            this.button_panel = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_toplamaq = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_cixmaq = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_vurmaq = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_bolmek = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.number_panel = new System.Windows.Forms.Panel();
            this.number_lbl = new System.Windows.Forms.Label();
            this.button_panel.SuspendLayout();
            this.number_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.btn_clear);
            this.button_panel.Controls.Add(this.btn_toplamaq);
            this.button_panel.Controls.Add(this.btn_equals);
            this.button_panel.Controls.Add(this.btn_0);
            this.button_panel.Controls.Add(this.btn_cixmaq);
            this.button_panel.Controls.Add(this.btn_3);
            this.button_panel.Controls.Add(this.btn_2);
            this.button_panel.Controls.Add(this.btn_1);
            this.button_panel.Controls.Add(this.btn_vurmaq);
            this.button_panel.Controls.Add(this.btn_6);
            this.button_panel.Controls.Add(this.btn_5);
            this.button_panel.Controls.Add(this.btn_4);
            this.button_panel.Controls.Add(this.btn_bolmek);
            this.button_panel.Controls.Add(this.btn_9);
            this.button_panel.Controls.Add(this.btn_8);
            this.button_panel.Controls.Add(this.btn_7);
            this.button_panel.Location = new System.Drawing.Point(12, 162);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(425, 425);
            this.button_panel.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clear.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(109, 321);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 100);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_toplamaq
            // 
            this.btn_toplamaq.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_toplamaq.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_toplamaq.Location = new System.Drawing.Point(321, 321);
            this.btn_toplamaq.Name = "btn_toplamaq";
            this.btn_toplamaq.Size = new System.Drawing.Size(100, 100);
            this.btn_toplamaq.TabIndex = 16;
            this.btn_toplamaq.Text = "+";
            this.btn_toplamaq.UseVisualStyleBackColor = false;
            this.btn_toplamaq.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_equals.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_equals.Location = new System.Drawing.Point(215, 321);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(100, 100);
            this.btn_equals.TabIndex = 14;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_0.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(3, 321);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(100, 100);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_cixmaq
            // 
            this.btn_cixmaq.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_cixmaq.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cixmaq.Location = new System.Drawing.Point(321, 215);
            this.btn_cixmaq.Name = "btn_cixmaq";
            this.btn_cixmaq.Size = new System.Drawing.Size(100, 100);
            this.btn_cixmaq.TabIndex = 12;
            this.btn_cixmaq.Text = "-";
            this.btn_cixmaq.UseVisualStyleBackColor = false;
            this.btn_cixmaq.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(215, 215);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 100);
            this.btn_3.TabIndex = 11;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(109, 215);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 100);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(3, 215);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 100);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_vurmaq
            // 
            this.btn_vurmaq.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_vurmaq.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_vurmaq.Location = new System.Drawing.Point(321, 109);
            this.btn_vurmaq.Name = "btn_vurmaq";
            this.btn_vurmaq.Size = new System.Drawing.Size(100, 100);
            this.btn_vurmaq.TabIndex = 8;
            this.btn_vurmaq.Text = "*";
            this.btn_vurmaq.UseVisualStyleBackColor = false;
            this.btn_vurmaq.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_6.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(215, 109);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 100);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_5.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(109, 109);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 100);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_4.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(3, 109);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 100);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_bolmek
            // 
            this.btn_bolmek.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_bolmek.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bolmek.Location = new System.Drawing.Point(321, 3);
            this.btn_bolmek.Name = "btn_bolmek";
            this.btn_bolmek.Size = new System.Drawing.Size(100, 100);
            this.btn_bolmek.TabIndex = 4;
            this.btn_bolmek.Text = "/";
            this.btn_bolmek.UseVisualStyleBackColor = false;
            this.btn_bolmek.Click += new System.EventHandler(this.mark_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_9.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(215, 3);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 100);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_8.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(109, 3);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 100);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_7.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(3, 3);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 100);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.number_Click);
            // 
            // number_panel
            // 
            this.number_panel.Controls.Add(this.number_lbl);
            this.number_panel.Location = new System.Drawing.Point(12, 12);
            this.number_panel.Name = "number_panel";
            this.number_panel.Size = new System.Drawing.Size(425, 144);
            this.number_panel.TabIndex = 1;
            // 
            // number_lbl
            // 
            this.number_lbl.AutoSize = true;
            this.number_lbl.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_lbl.Location = new System.Drawing.Point(6, 12);
            this.number_lbl.Name = "number_lbl";
            this.number_lbl.Size = new System.Drawing.Size(108, 119);
            this.number_lbl.TabIndex = 0;
            this.number_lbl.Text = "0";
            this.number_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 592);
            this.Controls.Add(this.number_panel);
            this.Controls.Add(this.button_panel);
            this.MaximumSize = new System.Drawing.Size(457, 631);
            this.MinimumSize = new System.Drawing.Size(457, 631);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.button_panel.ResumeLayout(false);
            this.number_panel.ResumeLayout(false);
            this.number_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel button_panel;
        private Button btn_7;
        private Button btn_toplamaq;
        private Button btn_equals;
        private Button btn_0;
        private Button btn_cixmaq;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_vurmaq;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_bolmek;
        private Button btn_9;
        private Button btn_8;
        private Panel number_panel;
        private Label number_lbl;
        private Button btn_clear;
    }
}