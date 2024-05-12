namespace project2022
{
    partial class BookReturn
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.dgvrental = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtextradays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfine = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbname = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblbid = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrental)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1046, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Search Customer by name";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbcustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustomer.ForeColor = System.Drawing.Color.Black;
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.IntegralHeight = false;
            this.cmbcustomer.Location = new System.Drawing.Point(1329, 167);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(256, 28);
            this.cmbcustomer.TabIndex = 1;
            this.cmbcustomer.SelectedIndexChanged += new System.EventHandler(this.cmbcustomer_SelectedIndexChanged);
            // 
            // dgvrental
            // 
            this.dgvrental.AllowUserToAddRows = false;
            this.dgvrental.AllowUserToDeleteRows = false;
            this.dgvrental.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvrental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrental.Location = new System.Drawing.Point(64, 212);
            this.dgvrental.Name = "dgvrental";
            this.dgvrental.ReadOnly = true;
            this.dgvrental.RowTemplate.Height = 24;
            this.dgvrental.Size = new System.Drawing.Size(1521, 241);
            this.dgvrental.TabIndex = 38;
            this.dgvrental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrental_CellContentClick);
            this.dgvrental.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvrental_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Select Rental info";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(375, 95);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(199, 38);
            this.txtdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total No.of Days Extra";
            // 
            // txtextradays
            // 
            this.txtextradays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtextradays.Location = new System.Drawing.Point(373, 544);
            this.txtextradays.Multiline = true;
            this.txtextradays.Name = "txtextradays";
            this.txtextradays.Size = new System.Drawing.Size(199, 38);
            this.txtextradays.TabIndex = 2;
            this.txtextradays.TextChanged += new System.EventHandler(this.txtextradays_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Total Rent";
            // 
            // txtrent
            // 
            this.txtrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrent.Location = new System.Drawing.Point(545, 640);
            this.txtrent.Multiline = true;
            this.txtrent.Name = "txtrent";
            this.txtrent.Size = new System.Drawing.Size(199, 48);
            this.txtrent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fine (in Rs)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtfine
            // 
            this.txtfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfine.Location = new System.Drawing.Point(888, 544);
            this.txtfine.Multiline = true;
            this.txtfine.Name = "txtfine";
            this.txtfine.Size = new System.Drawing.Size(199, 38);
            this.txtfine.TabIndex = 3;
            this.txtfine.TextChanged += new System.EventHandler(this.txtfine_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lavender;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(618, 831);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 48);
            this.btnsave.TabIndex = 49;
            this.btnsave.Text = "Submit";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(610, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 45);
            this.label10.TabIndex = 50;
            this.label10.Text = "Book Return";
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbname.Location = new System.Drawing.Point(1090, 476);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(0, 18);
            this.lblbname.TabIndex = 55;
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookname.Location = new System.Drawing.Point(1208, 476);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(0, 18);
            this.lblbookname.TabIndex = 54;
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.Location = new System.Drawing.Point(670, 481);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(0, 18);
            this.lblbid.TabIndex = 53;
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookid.Location = new System.Drawing.Point(763, 481);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(0, 18);
            this.lblbookid.TabIndex = 52;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(235, 481);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(0, 18);
            this.lblcid.TabIndex = 51;
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.Location = new System.Drawing.Point(362, 481);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(0, 18);
            this.lblcustid.TabIndex = 56;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(888, 95);
            this.txtinvoice.Multiline = true;
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(199, 38);
            this.txtinvoice.TabIndex = 57;
            this.txtinvoice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(732, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "Invoice No";
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project2022.Properties.Resources.peakpx_3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1672, 1055);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.lblbname);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.lblbid);
            this.Controls.Add(this.lblbookid);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtfine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtextradays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbcustomer);
            this.Controls.Add(this.dgvrental);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label1);
            this.Name = "BookReturn";
            this.Text = "BookReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.DataGridView dgvrental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtextradays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfine;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label label6;
    }
}