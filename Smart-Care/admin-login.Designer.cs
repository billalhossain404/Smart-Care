namespace Smart_Care
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.alogin = new System.Windows.Forms.Button();
            this.alogpass = new System.Windows.Forms.TextBox();
            this.alogid = new System.Windows.Forms.TextBox();
            this.apasstxt = new System.Windows.Forms.Label();
            this.ausertxt = new System.Windows.Forms.Label();
            this.asignup = new System.Windows.Forms.Button();
            this.aexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 72);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(241, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin  Login";
            // 
            // alogin
            // 
            this.alogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.alogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alogin.Location = new System.Drawing.Point(316, 387);
            this.alogin.Name = "alogin";
            this.alogin.Size = new System.Drawing.Size(116, 53);
            this.alogin.TabIndex = 11;
            this.alogin.Text = "Log in";
            this.alogin.UseVisualStyleBackColor = false;
            this.alogin.Click += new System.EventHandler(this.aloginbtn_Click);
            // 
            // alogpass
            // 
            this.alogpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alogpass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alogpass.Location = new System.Drawing.Point(305, 296);
            this.alogpass.Name = "alogpass";
            this.alogpass.Size = new System.Drawing.Size(191, 35);
            this.alogpass.TabIndex = 10;
            // 
            // alogid
            // 
            this.alogid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alogid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alogid.Location = new System.Drawing.Point(305, 226);
            this.alogid.Name = "alogid";
            this.alogid.Size = new System.Drawing.Size(191, 34);
            this.alogid.TabIndex = 9;
            // 
            // apasstxt
            // 
            this.apasstxt.AutoSize = true;
            this.apasstxt.BackColor = System.Drawing.Color.Transparent;
            this.apasstxt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apasstxt.Location = new System.Drawing.Point(142, 296);
            this.apasstxt.Name = "apasstxt";
            this.apasstxt.Size = new System.Drawing.Size(135, 32);
            this.apasstxt.TabIndex = 8;
            this.apasstxt.Text = "Password";
            // 
            // ausertxt
            // 
            this.ausertxt.AutoSize = true;
            this.ausertxt.BackColor = System.Drawing.Color.Transparent;
            this.ausertxt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausertxt.Location = new System.Drawing.Point(225, 226);
            this.ausertxt.Name = "ausertxt";
            this.ausertxt.Size = new System.Drawing.Size(42, 32);
            this.ausertxt.TabIndex = 7;
            this.ausertxt.Text = "ID";
            // 
            // asignup
            // 
            this.asignup.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.asignup.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asignup.Location = new System.Drawing.Point(183, 387);
            this.asignup.Name = "asignup";
            this.asignup.Size = new System.Drawing.Size(116, 53);
            this.asignup.TabIndex = 13;
            this.asignup.Text = "Sign Up";
            this.asignup.UseVisualStyleBackColor = false;
            this.asignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // aexit
            // 
            this.aexit.BackColor = System.Drawing.Color.Crimson;
            this.aexit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aexit.Location = new System.Drawing.Point(250, 464);
            this.aexit.Name = "aexit";
            this.aexit.Size = new System.Drawing.Size(116, 53);
            this.aexit.TabIndex = 14;
            this.aexit.Text = "Exit";
            this.aexit.UseVisualStyleBackColor = false;
            this.aexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 673);
            this.Controls.Add(this.aexit);
            this.Controls.Add(this.asignup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alogin);
            this.Controls.Add(this.alogpass);
            this.Controls.Add(this.alogid);
            this.Controls.Add(this.apasstxt);
            this.Controls.Add(this.ausertxt);
            this.Name = "admin_login";
            this.Text = "admin_login";
            this.Load += new System.EventHandler(this.admin_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button alogin;
        private System.Windows.Forms.TextBox alogpass;
        private System.Windows.Forms.TextBox alogid;
        private System.Windows.Forms.Label apasstxt;
        private System.Windows.Forms.Label ausertxt;
        private System.Windows.Forms.Button asignup;
        private System.Windows.Forms.Button aexit;
    }
}