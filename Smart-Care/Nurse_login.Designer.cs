namespace Smart_Care
{
    partial class Nurse_login
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
            this.nurselogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.taxPassword = new System.Windows.Forms.Label();
            this.taxEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nurselogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurselogin
            // 
            this.nurselogin.BackColor = System.Drawing.Color.White;
            this.nurselogin.Controls.Add(this.button3);
            this.nurselogin.Controls.Add(this.label1);
            this.nurselogin.Controls.Add(this.textBox2);
            this.nurselogin.Controls.Add(this.button1);
            this.nurselogin.Controls.Add(this.checkBox1);
            this.nurselogin.Controls.Add(this.taxPassword);
            this.nurselogin.Controls.Add(this.taxEmail);
            this.nurselogin.Controls.Add(this.textBox1);
            this.nurselogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.nurselogin.Location = new System.Drawing.Point(619, 0);
            this.nurselogin.Name = "nurselogin";
            this.nurselogin.Size = new System.Drawing.Size(701, 731);
            this.nurselogin.TabIndex = 11;
            this.nurselogin.Paint += new System.Windows.Forms.PaintEventHandler(this.nurselogin_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(609, 683);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nurse Portal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(271, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(168, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // taxPassword
            // 
            this.taxPassword.AutoSize = true;
            this.taxPassword.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPassword.Location = new System.Drawing.Point(62, 263);
            this.taxPassword.Name = "taxPassword";
            this.taxPassword.Size = new System.Drawing.Size(97, 30);
            this.taxPassword.TabIndex = 6;
            this.taxPassword.Text = "Password:";
            this.taxPassword.UseCompatibleTextRendering = true;
            // 
            // taxEmail
            // 
            this.taxEmail.AutoSize = true;
            this.taxEmail.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxEmail.Location = new System.Drawing.Point(94, 225);
            this.taxEmail.Name = "taxEmail";
            this.taxEmail.Size = new System.Drawing.Size(64, 24);
            this.taxEmail.TabIndex = 5;
            this.taxEmail.Text = "Email: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 73);
            this.label5.TabIndex = 4;
            this.label5.Text = "Smart Care";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 731);
            this.panel1.TabIndex = 10;
            // 
            // Nurse_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 731);
            this.Controls.Add(this.nurselogin);
            this.Controls.Add(this.panel1);
            this.Name = "Nurse_login";
            this.Text = "Nurse_login";
            this.nurselogin.ResumeLayout(false);
            this.nurselogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nurselogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label taxPassword;
        private System.Windows.Forms.Label taxEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}