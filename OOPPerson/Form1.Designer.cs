namespace OOPPerson
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.btnFirstPerson = new System.Windows.Forms.Button();
            this.btnSecondPerson = new System.Windows.Forms.Button();
            this.btnOlder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(81, 56);
            this.numYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 20);
            this.numYear.TabIndex = 1;
            this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(81, 115);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 17);
            this.cbMale.TabIndex = 2;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // btnFirstPerson
            // 
            this.btnFirstPerson.Location = new System.Drawing.Point(221, 10);
            this.btnFirstPerson.Name = "btnFirstPerson";
            this.btnFirstPerson.Size = new System.Drawing.Size(179, 23);
            this.btnFirstPerson.TabIndex = 3;
            this.btnFirstPerson.Text = "Reading data of first person";
            this.btnFirstPerson.UseVisualStyleBackColor = true;
            this.btnFirstPerson.Click += new System.EventHandler(this.btnFirstPerson_Click);
            // 
            // btnSecondPerson
            // 
            this.btnSecondPerson.Location = new System.Drawing.Point(221, 56);
            this.btnSecondPerson.Name = "btnSecondPerson";
            this.btnSecondPerson.Size = new System.Drawing.Size(179, 23);
            this.btnSecondPerson.TabIndex = 4;
            this.btnSecondPerson.Text = "Reading data of second person";
            this.btnSecondPerson.UseVisualStyleBackColor = true;
            this.btnSecondPerson.Click += new System.EventHandler(this.btnSecondPerson_Click);
            // 
            // btnOlder
            // 
            this.btnOlder.Location = new System.Drawing.Point(81, 187);
            this.btnOlder.Name = "btnOlder";
            this.btnOlder.Size = new System.Drawing.Size(100, 23);
            this.btnOlder.TabIndex = 5;
            this.btnOlder.Text = "Who was older?";
            this.btnOlder.UseVisualStyleBackColor = true;
            this.btnOlder.Click += new System.EventHandler(this.btnOlder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of birth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlder);
            this.Controls.Add(this.btnSecondPerson);
            this.Controls.Add(this.btnFirstPerson);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Person\'s age comparison";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Button btnFirstPerson;
        private System.Windows.Forms.Button btnSecondPerson;
        private System.Windows.Forms.Button btnOlder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

