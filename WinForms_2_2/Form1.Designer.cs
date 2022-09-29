namespace WinForms_2_2
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
            this.loadName_txt = new System.Windows.Forms.TextBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.anket_gb = new System.Windows.Forms.GroupBox();
            this.phone_txt = new System.Windows.Forms.MaskedTextBox();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.save_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.country_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.father_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anket_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadName_txt
            // 
            this.loadName_txt.Location = new System.Drawing.Point(43, 12);
            this.loadName_txt.Name = "loadName_txt";
            this.loadName_txt.PlaceholderText = "Enter name";
            this.loadName_txt.Size = new System.Drawing.Size(151, 23);
            this.loadName_txt.TabIndex = 0;
            this.loadName_txt.Text = "\r\n";
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(216, 11);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_Click);
            // 
            // anket_gb
            // 
            this.anket_gb.Controls.Add(this.phone_txt);
            this.anket_gb.Controls.Add(this.female_rb);
            this.anket_gb.Controls.Add(this.male_rb);
            this.anket_gb.Controls.Add(this.date_dtp);
            this.anket_gb.Controls.Add(this.save_btn);
            this.anket_gb.Controls.Add(this.label8);
            this.anket_gb.Controls.Add(this.label7);
            this.anket_gb.Controls.Add(this.label6);
            this.anket_gb.Controls.Add(this.city_txt);
            this.anket_gb.Controls.Add(this.label5);
            this.anket_gb.Controls.Add(this.country_txt);
            this.anket_gb.Controls.Add(this.label4);
            this.anket_gb.Controls.Add(this.father_txt);
            this.anket_gb.Controls.Add(this.label3);
            this.anket_gb.Controls.Add(this.name_txt);
            this.anket_gb.Controls.Add(this.label2);
            this.anket_gb.Controls.Add(this.surname_txt);
            this.anket_gb.Controls.Add(this.label1);
            this.anket_gb.Location = new System.Drawing.Point(12, 41);
            this.anket_gb.Name = "anket_gb";
            this.anket_gb.Size = new System.Drawing.Size(319, 324);
            this.anket_gb.TabIndex = 2;
            this.anket_gb.TabStop = false;
            this.anket_gb.Text = "Anket";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(125, 175);
            this.phone_txt.Mask = "(999) 000-00-00";
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(187, 23);
            this.phone_txt.TabIndex = 18;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Location = new System.Drawing.Point(204, 262);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(63, 19);
            this.female_rb.TabIndex = 17;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Checked = true;
            this.male_rb.Location = new System.Drawing.Point(113, 262);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(51, 19);
            this.male_rb.TabIndex = 16;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // date_dtp
            // 
            this.date_dtp.CustomFormat = "dd MMMM yyyy";
            this.date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dtp.Location = new System.Drawing.Point(113, 222);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(200, 23);
            this.date_dtp.TabIndex = 15;
            this.date_dtp.Value = new System.DateTime(2022, 9, 29, 10, 2, 57, 0);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(6, 293);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(307, 23);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number";
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(125, 144);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(188, 23);
            this.city_txt.TabIndex = 9;
            this.city_txt.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // country_txt
            // 
            this.country_txt.Location = new System.Drawing.Point(125, 115);
            this.country_txt.Name = "country_txt";
            this.country_txt.Size = new System.Drawing.Size(188, 23);
            this.country_txt.TabIndex = 7;
            this.country_txt.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // father_txt
            // 
            this.father_txt.Location = new System.Drawing.Point(108, 77);
            this.father_txt.Name = "father_txt";
            this.father_txt.Size = new System.Drawing.Size(205, 23);
            this.father_txt.TabIndex = 5;
            this.father_txt.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Father name";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(108, 48);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(205, 23);
            this.name_txt.TabIndex = 3;
            this.name_txt.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(108, 19);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(205, 23);
            this.surname_txt.TabIndex = 1;
            this.surname_txt.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 373);
            this.Controls.Add(this.anket_gb);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.loadName_txt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket";
            this.anket_gb.ResumeLayout(false);
            this.anket_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loadName_txt;
        private Button load_btn;
        private GroupBox anket_gb;
        private Label label6;
        private TextBox city_txt;
        private Label label5;
        private TextBox country_txt;
        private Label label4;
        private TextBox father_txt;
        private Label label3;
        private TextBox name_txt;
        private Label label2;
        private TextBox surname_txt;
        private Label label1;
        private Label label7;
        private Label label8;
        private DateTimePicker date_dtp;
        private Button save_btn;
        private RadioButton female_rb;
        private RadioButton male_rb;
        private MaskedTextBox phone_txt;
    }
}