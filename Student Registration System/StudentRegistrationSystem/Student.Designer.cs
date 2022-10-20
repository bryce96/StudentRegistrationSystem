
namespace StudentRegistrationSystem
{
    partial class Student
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.RecordSearchbtn = new System.Windows.Forms.Button();
            this.GridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OptionsOutput = new System.Windows.Forms.Label();
            this.CreditHours = new System.Windows.Forms.Button();
            this.Calcbtn = new System.Windows.Forms.Button();
            this.PrintRecordbtn = new System.Windows.Forms.Button();
            this.printStudentRecords = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDtxt);
            this.groupBox1.Controls.Add(this.RecordSearchbtn);
            this.groupBox1.Location = new System.Drawing.Point(29, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(133, 60);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(192, 35);
            this.IDtxt.TabIndex = 1;
            // 
            // RecordSearchbtn
            // 
            this.RecordSearchbtn.Location = new System.Drawing.Point(103, 119);
            this.RecordSearchbtn.Name = "RecordSearchbtn";
            this.RecordSearchbtn.Size = new System.Drawing.Size(131, 40);
            this.RecordSearchbtn.TabIndex = 0;
            this.RecordSearchbtn.Text = "Search";
            this.RecordSearchbtn.UseVisualStyleBackColor = true;
            this.RecordSearchbtn.Click += new System.EventHandler(this.RecordSearchbtn_Click);
            // 
            // GridView3
            // 
            this.GridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView3.Location = new System.Drawing.Point(35, 320);
            this.GridView3.Name = "GridView3";
            this.GridView3.RowHeadersWidth = 72;
            this.GridView3.RowTemplate.Height = 37;
            this.GridView3.Size = new System.Drawing.Size(898, 284);
            this.GridView3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OptionsOutput);
            this.groupBox2.Controls.Add(this.CreditHours);
            this.groupBox2.Controls.Add(this.Calcbtn);
            this.groupBox2.Controls.Add(this.PrintRecordbtn);
            this.groupBox2.Location = new System.Drawing.Point(411, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // OptionsOutput
            // 
            this.OptionsOutput.Location = new System.Drawing.Point(28, 63);
            this.OptionsOutput.Name = "OptionsOutput";
            this.OptionsOutput.Size = new System.Drawing.Size(289, 121);
            this.OptionsOutput.TabIndex = 3;
            // 
            // CreditHours
            // 
            this.CreditHours.Location = new System.Drawing.Point(350, 155);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(166, 40);
            this.CreditHours.TabIndex = 2;
            this.CreditHours.Text = "Credit Hours";
            this.CreditHours.UseVisualStyleBackColor = true;
            this.CreditHours.Click += new System.EventHandler(this.CreditHours_Click);
            // 
            // Calcbtn
            // 
            this.Calcbtn.Location = new System.Drawing.Point(350, 92);
            this.Calcbtn.Name = "Calcbtn";
            this.Calcbtn.Size = new System.Drawing.Size(166, 43);
            this.Calcbtn.TabIndex = 1;
            this.Calcbtn.Text = "Calculate Total";
            this.Calcbtn.UseVisualStyleBackColor = true;
            this.Calcbtn.Click += new System.EventHandler(this.Calcbtn_Click);
            // 
            // PrintRecordbtn
            // 
            this.PrintRecordbtn.Location = new System.Drawing.Point(350, 30);
            this.PrintRecordbtn.Name = "PrintRecordbtn";
            this.PrintRecordbtn.Size = new System.Drawing.Size(166, 40);
            this.PrintRecordbtn.TabIndex = 0;
            this.PrintRecordbtn.Text = "Print Record";
            this.PrintRecordbtn.UseVisualStyleBackColor = true;
            this.PrintRecordbtn.Click += new System.EventHandler(this.PrintRecordbtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridView3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student";
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button RecordSearchbtn;
        private System.Windows.Forms.DataGridView GridView3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label OptionsOutput;
        private System.Windows.Forms.Button CreditHours;
        private System.Windows.Forms.Button Calcbtn;
        private System.Windows.Forms.Button PrintRecordbtn;
        private System.Drawing.Printing.PrintDocument printStudentRecords;
    }
}