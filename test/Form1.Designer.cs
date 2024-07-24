namespace test
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
            this.cmbDeyOfWik = new System.Windows.Forms.ComboBox();
            this.cmbDeyOfManth = new System.Windows.Forms.ComboBox();
            this.cmbManth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDeyOfWik
            // 
            this.cmbDeyOfWik.FormattingEnabled = true;
            this.cmbDeyOfWik.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.cmbDeyOfWik.Location = new System.Drawing.Point(643, 114);
            this.cmbDeyOfWik.Name = "cmbDeyOfWik";
            this.cmbDeyOfWik.Size = new System.Drawing.Size(121, 24);
            this.cmbDeyOfWik.TabIndex = 0;
            // 
            // cmbDeyOfManth
            // 
            this.cmbDeyOfManth.FormattingEnabled = true;
            this.cmbDeyOfManth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDeyOfManth.Location = new System.Drawing.Point(477, 114);
            this.cmbDeyOfManth.Name = "cmbDeyOfManth";
            this.cmbDeyOfManth.Size = new System.Drawing.Size(121, 24);
            this.cmbDeyOfManth.TabIndex = 1;
            // 
            // cmbManth
            // 
            this.cmbManth.FormattingEnabled = true;
            this.cmbManth.Items.AddRange(new object[] {
            "תשרי",
            "חשוון",
            "כסליו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב ",
            "אלול"});
            this.cmbManth.Location = new System.Drawing.Point(314, 114);
            this.cmbManth.Name = "cmbManth";
            this.cmbManth.Size = new System.Drawing.Size(121, 24);
            this.cmbManth.TabIndex = 2;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "תשפ\'ד",
            "תשפ\'ה",
            "תשפ\'ו",
            "תשפ\'ז",
            "תשפ\'ח",
            "תשפ\'ט",
            "תש\'צ",
            "תשצ\'א",
            "תשצ\'ב",
            "תשצ\'ג"});
            this.cmbYear.Location = new System.Drawing.Point(122, 114);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "מערכת גיטים אההההה\r\nהכנס תאריך יא פחשיש\r\n";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "כתיבה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "היום בחודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "חודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "שנה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "התאריך הוא\r\nכדלהלן\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbManth);
            this.Controls.Add(this.cmbDeyOfManth);
            this.Controls.Add(this.cmbDeyOfWik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeyOfWik;
        private System.Windows.Forms.ComboBox cmbDeyOfManth;
        private System.Windows.Forms.ComboBox cmbManth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

