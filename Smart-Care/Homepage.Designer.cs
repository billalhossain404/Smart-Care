namespace Smart_Care
{
    partial class Homepage
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
            this.account = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.Button();
            this.viewprofile = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.doctordatagrid = new System.Windows.Forms.DataGridView();
            this.dctrserchbox = new System.Windows.Forms.TextBox();
            this.searchdctr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctordatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.Gold;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.Black;
            this.account.Location = new System.Drawing.Point(1255, -3);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(138, 48);
            this.account.TabIndex = 60;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.ForestGreen;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(771, 517);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(266, 49);
            this.book.TabIndex = 59;
            this.book.Text = "Book Appointment";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // viewprofile
            // 
            this.viewprofile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewprofile.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewprofile.ForeColor = System.Drawing.Color.White;
            this.viewprofile.Location = new System.Drawing.Point(422, 517);
            this.viewprofile.Name = "viewprofile";
            this.viewprofile.Size = new System.Drawing.Size(147, 49);
            this.viewprofile.TabIndex = 58;
            this.viewprofile.Text = "View Profile";
            this.viewprofile.UseVisualStyleBackColor = false;
            this.viewprofile.Click += new System.EventHandler(this.viewprofile_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Blue;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(801, 59);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 45);
            this.search.TabIndex = 57;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // doctordatagrid
            // 
            this.doctordatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctordatagrid.Location = new System.Drawing.Point(215, 148);
            this.doctordatagrid.Name = "doctordatagrid";
            this.doctordatagrid.RowHeadersWidth = 51;
            this.doctordatagrid.RowTemplate.Height = 24;
            this.doctordatagrid.Size = new System.Drawing.Size(957, 343);
            this.doctordatagrid.TabIndex = 56;
            // 
            // dctrserchbox
            // 
            this.dctrserchbox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dctrserchbox.Location = new System.Drawing.Point(468, 60);
            this.dctrserchbox.Name = "dctrserchbox";
            this.dctrserchbox.Size = new System.Drawing.Size(287, 39);
            this.dctrserchbox.TabIndex = 55;
            // 
            // searchdctr
            // 
            this.searchdctr.AutoSize = true;
            this.searchdctr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdctr.Location = new System.Drawing.Point(364, 73);
            this.searchdctr.Name = "searchdctr";
            this.searchdctr.Size = new System.Drawing.Size(81, 26);
            this.searchdctr.TabIndex = 54;
            this.searchdctr.Text = "Doctor";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1392, 718);
            this.Controls.Add(this.account);
            this.Controls.Add(this.book);
            this.Controls.Add(this.viewprofile);
            this.Controls.Add(this.search);
            this.Controls.Add(this.doctordatagrid);
            this.Controls.Add(this.dctrserchbox);
            this.Controls.Add(this.searchdctr);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctordatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button viewprofile;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView doctordatagrid;
        private System.Windows.Forms.TextBox dctrserchbox;
        private System.Windows.Forms.Label searchdctr;
    }
}