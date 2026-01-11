namespace Smart_Care
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbexit = new System.Windows.Forms.Button();
            this.dbambulance = new System.Windows.Forms.Button();
            this.dbpayment = new System.Windows.Forms.Button();
            this.dbappointment = new System.Windows.Forms.Button();
            this.bdnurse = new System.Windows.Forms.Button();
            this.dbdctr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 113);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SmartCare – Integrated Hospital and Patient Flow Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.dbexit);
            this.panel2.Controls.Add(this.dbambulance);
            this.panel2.Controls.Add(this.dbpayment);
            this.panel2.Controls.Add(this.dbappointment);
            this.panel2.Controls.Add(this.bdnurse);
            this.panel2.Controls.Add(this.dbdctr);
            this.panel2.Location = new System.Drawing.Point(1, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 623);
            this.panel2.TabIndex = 3;
            // 
            // dbexit
            // 
            this.dbexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbexit.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbexit.Location = new System.Drawing.Point(73, 472);
            this.dbexit.Name = "dbexit";
            this.dbexit.Size = new System.Drawing.Size(222, 48);
            this.dbexit.TabIndex = 8;
            this.dbexit.Text = "Exit";
            this.dbexit.UseVisualStyleBackColor = true;
            this.dbexit.Click += new System.EventHandler(this.button7_Click);
            // 
            // dbambulance
            // 
            this.dbambulance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbambulance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbambulance.Location = new System.Drawing.Point(73, 385);
            this.dbambulance.Name = "dbambulance";
            this.dbambulance.Size = new System.Drawing.Size(222, 48);
            this.dbambulance.TabIndex = 7;
            this.dbambulance.Text = "Ambulance";
            this.dbambulance.UseVisualStyleBackColor = true;
            // 
            // dbpayment
            // 
            this.dbpayment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbpayment.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbpayment.Location = new System.Drawing.Point(73, 304);
            this.dbpayment.Name = "dbpayment";
            this.dbpayment.Size = new System.Drawing.Size(222, 48);
            this.dbpayment.TabIndex = 6;
            this.dbpayment.Text = "Payment";
            this.dbpayment.UseVisualStyleBackColor = true;
            // 
            // dbappointment
            // 
            this.dbappointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbappointment.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbappointment.Location = new System.Drawing.Point(73, 218);
            this.dbappointment.Name = "dbappointment";
            this.dbappointment.Size = new System.Drawing.Size(222, 48);
            this.dbappointment.TabIndex = 5;
            this.dbappointment.Text = "Appointment";
            this.dbappointment.UseVisualStyleBackColor = true;
            // 
            // bdnurse
            // 
            this.bdnurse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bdnurse.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdnurse.Location = new System.Drawing.Point(73, 135);
            this.bdnurse.Name = "bdnurse";
            this.bdnurse.Size = new System.Drawing.Size(222, 48);
            this.bdnurse.TabIndex = 4;
            this.bdnurse.Text = "Nurse";
            this.bdnurse.UseVisualStyleBackColor = true;
            // 
            // dbdctr
            // 
            this.dbdctr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbdctr.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbdctr.Location = new System.Drawing.Point(73, 45);
            this.dbdctr.Name = "dbdctr";
            this.dbdctr.Size = new System.Drawing.Size(222, 48);
            this.dbdctr.TabIndex = 3;
            this.dbdctr.Text = "Doctor";
            this.dbdctr.UseVisualStyleBackColor = true;
            this.dbdctr.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dbambulance;
        private System.Windows.Forms.Button dbpayment;
        private System.Windows.Forms.Button dbappointment;
        private System.Windows.Forms.Button bdnurse;
        private System.Windows.Forms.Button dbdctr;
        private System.Windows.Forms.Button dbexit;
    }
}