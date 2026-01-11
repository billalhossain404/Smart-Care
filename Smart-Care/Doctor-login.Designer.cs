namespace Smart_Care
{
    partial class Doctor_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_login));
            this.dctrimg = new System.Windows.Forms.PictureBox();
            this.patientlist = new System.Windows.Forms.Label();
            this.dctrdatagrid = new System.Windows.Forms.DataGridView();
            this.dctrpanname = new System.Windows.Forms.Label();
            this.dctrpan = new System.Windows.Forms.Panel();
            this.totalpatient = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dctrname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dctrimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctrdatagrid)).BeginInit();
            this.dctrpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dctrimg
            // 
            this.dctrimg.Location = new System.Drawing.Point(17, 15);
            this.dctrimg.Name = "dctrimg";
            this.dctrimg.Size = new System.Drawing.Size(282, 276);
            this.dctrimg.TabIndex = 7;
            this.dctrimg.TabStop = false;
            // 
            // patientlist
            // 
            this.patientlist.AutoSize = true;
            this.patientlist.BackColor = System.Drawing.Color.CornflowerBlue;
            this.patientlist.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientlist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patientlist.Location = new System.Drawing.Point(11, 331);
            this.patientlist.Name = "patientlist";
            this.patientlist.Size = new System.Drawing.Size(162, 35);
            this.patientlist.TabIndex = 6;
            this.patientlist.Text = "Patient List";
            // 
            // dctrdatagrid
            // 
            this.dctrdatagrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dctrdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dctrdatagrid.Location = new System.Drawing.Point(-1, 369);
            this.dctrdatagrid.Name = "dctrdatagrid";
            this.dctrdatagrid.RowHeadersWidth = 51;
            this.dctrdatagrid.RowTemplate.Height = 24;
            this.dctrdatagrid.Size = new System.Drawing.Size(1331, 382);
            this.dctrdatagrid.TabIndex = 5;
            // 
            // dctrpanname
            // 
            this.dctrpanname.AutoSize = true;
            this.dctrpanname.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrpanname.Location = new System.Drawing.Point(49, 12);
            this.dctrpanname.Name = "dctrpanname";
            this.dctrpanname.Size = new System.Drawing.Size(166, 32);
            this.dctrpanname.TabIndex = 0;
            this.dctrpanname.Text = "Total Patient";
            // 
            // dctrpan
            // 
            this.dctrpan.Controls.Add(this.totalpatient);
            this.dctrpan.Controls.Add(this.dctrpanname);
            this.dctrpan.Location = new System.Drawing.Point(860, 164);
            this.dctrpan.Name = "dctrpan";
            this.dctrpan.Size = new System.Drawing.Size(257, 127);
            this.dctrpan.TabIndex = 9;
            // 
            // totalpatient
            // 
            this.totalpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalpatient.Location = new System.Drawing.Point(72, 47);
            this.totalpatient.Name = "totalpatient";
            this.totalpatient.Size = new System.Drawing.Size(126, 64);
            this.totalpatient.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1275, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 47);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dctrname
            // 
            this.dctrname.AutoSize = true;
            this.dctrname.BackColor = System.Drawing.Color.Transparent;
            this.dctrname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dctrname.Location = new System.Drawing.Point(318, 32);
            this.dctrname.Name = "dctrname";
            this.dctrname.Size = new System.Drawing.Size(79, 23);
            this.dctrname.TabIndex = 11;
            this.dctrname.Text = "Name : ";
            // 
            // Doctor_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1329, 744);
            this.Controls.Add(this.dctrname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dctrimg);
            this.Controls.Add(this.patientlist);
            this.Controls.Add(this.dctrdatagrid);
            this.Controls.Add(this.dctrpan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor_login";
            this.Text = "Doctor_login";
            this.Load += new System.EventHandler(this.Doctor_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dctrimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctrdatagrid)).EndInit();
            this.dctrpan.ResumeLayout(false);
            this.dctrpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dctrimg;
        private System.Windows.Forms.Label patientlist;
        private System.Windows.Forms.DataGridView dctrdatagrid;
        private System.Windows.Forms.Label dctrpanname;
        private System.Windows.Forms.Panel dctrpan;
        private System.Windows.Forms.Panel totalpatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dctrname;
    }
}