
namespace StudentRegistrationSystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Studentbutton = new System.Windows.Forms.Button();
            this.Administrativebutton = new System.Windows.Forms.Button();
            this.Registrationbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.Studentbutton);
            this.panel1.Controls.Add(this.Administrativebutton);
            this.panel1.Controls.Add(this.Registrationbutton);
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 103);
            this.panel1.TabIndex = 0;
            // 
            // Studentbutton
            // 
            this.Studentbutton.Location = new System.Drawing.Point(939, 14);
            this.Studentbutton.Name = "Studentbutton";
            this.Studentbutton.Size = new System.Drawing.Size(207, 74);
            this.Studentbutton.TabIndex = 2;
            this.Studentbutton.Text = "Student";
            this.Studentbutton.UseVisualStyleBackColor = true;
            this.Studentbutton.Click += new System.EventHandler(this.Studentbutton_Click);
            // 
            // Administrativebutton
            // 
            this.Administrativebutton.Location = new System.Drawing.Point(529, 14);
            this.Administrativebutton.Name = "Administrativebutton";
            this.Administrativebutton.Size = new System.Drawing.Size(207, 74);
            this.Administrativebutton.TabIndex = 1;
            this.Administrativebutton.Text = "Administrative";
            this.Administrativebutton.UseVisualStyleBackColor = true;
            this.Administrativebutton.Click += new System.EventHandler(this.Administrativebutton_Click);
            // 
            // Registrationbutton
            // 
            this.Registrationbutton.Location = new System.Drawing.Point(123, 14);
            this.Registrationbutton.Name = "Registrationbutton";
            this.Registrationbutton.Size = new System.Drawing.Size(207, 74);
            this.Registrationbutton.TabIndex = 0;
            this.Registrationbutton.Text = "Registration";
            this.Registrationbutton.UseVisualStyleBackColor = true;
            this.Registrationbutton.Click += new System.EventHandler(this.Registrationbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-63, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1319, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Studentbutton;
        private System.Windows.Forms.Button Administrativebutton;
        private System.Windows.Forms.Button Registrationbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

