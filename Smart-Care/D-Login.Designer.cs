namespace Smart_Care
{
    partial class D_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dctrexit = new System.Windows.Forms.Button();
            this.dctrlogin = new System.Windows.Forms.Button();
            this.dctrpass = new System.Windows.Forms.TextBox();
            this.dctruser = new System.Windows.Forms.TextBox();
            this.apasstxt = new System.Windows.Forms.Label();
            this.ausertxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 84);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(241, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doctor  Login";
            // 
            // dctrexit
            // 
            this.dctrexit.BackColor = System.Drawing.Color.Crimson;
            this.dctrexit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dctrexit.Location = new System.Drawing.Point(223, 340);
            this.dctrexit.Name = "dctrexit";
            this.dctrexit.Size = new System.Drawing.Size(116, 53);
            this.dctrexit.TabIndex = 22;
            this.dctrexit.Text = "Back";
            this.dctrexit.UseVisualStyleBackColor = false;
            this.dctrexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // dctrlogin
            // 
            this.dctrlogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dctrlogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dctrlogin.Location = new System.Drawing.Point(358, 340);
            this.dctrlogin.Name = "dctrlogin";
            this.dctrlogin.Size = new System.Drawing.Size(116, 53);
            this.dctrlogin.TabIndex = 19;
            this.dctrlogin.Text = "Log in";
            this.dctrlogin.UseVisualStyleBackColor = false;
            this.dctrlogin.Click += new System.EventHandler(this.aloginbtn_Click);
            // 
            // dctrpass
            // 
            this.dctrpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dctrpass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrpass.Location = new System.Drawing.Point(327, 257);
            this.dctrpass.Name = "dctrpass";
            this.dctrpass.Size = new System.Drawing.Size(191, 35);
            this.dctrpass.TabIndex = 18;
            // 
            // dctruser
            // 
            this.dctruser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dctruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctruser.Location = new System.Drawing.Point(327, 187);
            this.dctruser.Name = "dctruser";
            this.dctruser.Size = new System.Drawing.Size(191, 34);
            this.dctruser.TabIndex = 17;
            // 
            // apasstxt
            // 
            this.apasstxt.AutoSize = true;
            this.apasstxt.BackColor = System.Drawing.Color.Transparent;
            this.apasstxt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apasstxt.Location = new System.Drawing.Point(164, 257);
            this.apasstxt.Name = "apasstxt";
            this.apasstxt.Size = new System.Drawing.Size(135, 32);
            this.apasstxt.TabIndex = 16;
            this.apasstxt.Text = "Password";
            // 
            // ausertxt
            // 
            this.ausertxt.AutoSize = true;
            this.ausertxt.BackColor = System.Drawing.Color.Transparent;
            this.ausertxt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausertxt.Location = new System.Drawing.Point(162, 187);
            this.ausertxt.Name = "ausertxt";
            this.ausertxt.Size = new System.Drawing.Size(142, 32);
            this.ausertxt.TabIndex = 15;
            this.ausertxt.Text = "Username";
            // 
            // D_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dctrexit);
            this.Controls.Add(this.dctrlogin);
            this.Controls.Add(this.dctrpass);
            this.Controls.Add(this.dctruser);
            this.Controls.Add(this.apasstxt);
            this.Controls.Add(this.ausertxt);
            this.Name = "D_Login";
            this.Text = "D_Login";
            this.Load += new System.EventHandler(this.D_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dctrexit;
        private System.Windows.Forms.Button dctrlogin;
        private System.Windows.Forms.TextBox dctrpass;
        private System.Windows.Forms.TextBox dctruser;
        private System.Windows.Forms.Label apasstxt;
        private System.Windows.Forms.Label ausertxt;
    }
}