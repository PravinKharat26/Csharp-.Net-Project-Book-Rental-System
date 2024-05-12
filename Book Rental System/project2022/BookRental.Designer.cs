namespace project2022
{
    partial class BookRental
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrent = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.dgvcust = new System.Windows.Forms.DataGridView();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lblbook = new System.Windows.Forms.Label();
            this.lblcust = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalrent = new System.Windows.Forms.TextBox();
            this.lblbook2 = new System.Windows.Forms.Label();
            this.lblcust3 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblcon = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.cmbbook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbname = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(180, 88);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(199, 38);
            this.txtdate.TabIndex = 0;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rent/day(Rs)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rent upto date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. of  Days";
            // 
            // txtrent
            // 
            this.txtrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrent.Location = new System.Drawing.Point(208, 437);
            this.txtrent.Multiline = true;
            this.txtrent.Name = "txtrent";
            this.txtrent.Size = new System.Drawing.Size(195, 38);
            this.txtrent.TabIndex = 9;
            this.txtrent.Text = "1";
            this.txtrent.TextChanged += new System.EventHandler(this.txtrent_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(982, 442);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 17, 13, 8, 1, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtdays
            // 
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdays.Location = new System.Drawing.Point(208, 489);
            this.txtdays.Multiline = true;
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(195, 38);
            this.txtdays.TabIndex = 1;
            // 
            // dgvcust
            // 
            this.dgvcust.AllowUserToAddRows = false;
            this.dgvcust.AllowUserToDeleteRows = false;
            this.dgvcust.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcust.Location = new System.Drawing.Point(180, 582);
            this.dgvcust.Name = "dgvcust";
            this.dgvcust.ReadOnly = true;
            this.dgvcust.RowTemplate.Height = 24;
            this.dgvcust.Size = new System.Drawing.Size(1125, 189);
            this.dgvcust.TabIndex = 12;
            this.dgvcust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcust_CellContentClick);
            this.dgvcust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcust_RowHeaderMouseClick);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(180, 169);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(1125, 189);
            this.dgvBook.TabIndex = 14;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBook_RowHeaderMouseClick);
            // 
            // lblbook
            // 
            this.lblbook.AutoSize = true;
            this.lblbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbook.Location = new System.Drawing.Point(263, 380);
            this.lblbook.Name = "lblbook";
            this.lblbook.Size = new System.Drawing.Size(0, 18);
            this.lblbook.TabIndex = 15;
            this.lblbook.Click += new System.EventHandler(this.lblbook_Click);
            // 
            // lblcust
            // 
            this.lblcust.AutoSize = true;
            this.lblcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust.Location = new System.Drawing.Point(311, 793);
            this.lblcust.Name = "lblcust";
            this.lblcust.Size = new System.Drawing.Size(0, 18);
            this.lblcust.TabIndex = 17;
            this.lblcust.Click += new System.EventHandler(this.lblcust_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(788, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Rent(Rs)";
            // 
            // txttotalrent
            // 
            this.txttotalrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalrent.Location = new System.Drawing.Point(977, 490);
            this.txttotalrent.Multiline = true;
            this.txttotalrent.Name = "txttotalrent";
            this.txttotalrent.Size = new System.Drawing.Size(195, 38);
            this.txttotalrent.TabIndex = 2;
            // 
            // lblbook2
            // 
            this.lblbook2.AutoSize = true;
            this.lblbook2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbook2.Location = new System.Drawing.Point(746, 378);
            this.lblbook2.Name = "lblbook2";
            this.lblbook2.Size = new System.Drawing.Size(0, 18);
            this.lblbook2.TabIndex = 22;
            // 
            // lblcust3
            // 
            this.lblcust3.AutoSize = true;
            this.lblcust3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust3.Location = new System.Drawing.Point(1062, 793);
            this.lblcust3.Name = "lblcust3";
            this.lblcust3.Size = new System.Drawing.Size(0, 18);
            this.lblcust3.TabIndex = 24;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(180, 380);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 18);
            this.lblid.TabIndex = 25;
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisbn.Location = new System.Drawing.Point(675, 378);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(0, 18);
            this.lblisbn.TabIndex = 26;
            this.lblisbn.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(198, 793);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(0, 18);
            this.lblcid.TabIndex = 27;
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon.Location = new System.Drawing.Point(981, 793);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(0, 18);
            this.lblcon.TabIndex = 28;
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.Location = new System.Drawing.Point(460, 793);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(0, 18);
            this.lblcname.TabIndex = 29;
            this.lblcname.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(626, 793);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(0, 18);
            this.lblcustname.TabIndex = 30;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(198, 851);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(0, 18);
            this.lbladd.TabIndex = 31;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(356, 851);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(0, 18);
            this.lbladdress.TabIndex = 35;
            // 
            // cmbbook
            // 
            this.cmbbook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbbook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbook.ForeColor = System.Drawing.Color.Black;
            this.cmbbook.FormattingEnabled = true;
            this.cmbbook.IntegralHeight = false;
            this.cmbbook.Location = new System.Drawing.Point(1407, 210);
            this.cmbbook.Name = "cmbbook";
            this.cmbbook.Size = new System.Drawing.Size(256, 28);
            this.cmbbook.TabIndex = 33;
            this.cmbbook.SelectedIndexChanged += new System.EventHandler(this.cmbbook_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1404, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Select Book:";
            // 
            // cmbcust
            // 
            this.cmbcust.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbcust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcust.ForeColor = System.Drawing.Color.Black;
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(1410, 644);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(265, 28);
            this.cmbcust.TabIndex = 36;
            this.cmbcust.SelectedIndexChanged += new System.EventHandler(this.cmbcust_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1407, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Select Customer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(662, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 45);
            this.label10.TabIndex = 38;
            this.label10.Text = "Book Rental";
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbname.Location = new System.Drawing.Point(1117, 375);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(0, 18);
            this.lblbname.TabIndex = 40;
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookname.Location = new System.Drawing.Point(1227, 375);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(0, 18);
            this.lblbookname.TabIndex = 39;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lavender;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(652, 880);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 59);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Submit";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // BookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project2022.Properties.Resources.peakpx_3_;
            this.ClientSize = new System.Drawing.Size(1842, 1055);
            this.Controls.Add(this.lblbname);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbcust);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbook);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblcname);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblcust3);
            this.Controls.Add(this.lblbook2);
            this.Controls.Add(this.txttotalrent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcust);
            this.Controls.Add(this.lblbook);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvcust);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtrent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label1);
            this.Name = "BookRental";
            this.Text = "-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.DataGridView dgvcust;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblbook;
        private System.Windows.Forms.Label lblcust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalrent;
        private System.Windows.Forms.Label lblbook2;
        private System.Windows.Forms.Label lblcust3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lblcon;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.ComboBox cmbbook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.Label lblbookname;
    }
}