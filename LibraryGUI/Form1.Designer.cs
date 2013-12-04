namespace LibraryGUI
{
    partial class LIBRARY
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BookId_text = new System.Windows.Forms.TextBox();
            this.FindBook_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorName_text = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmCheckOut_Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.CardNo_text = new System.Windows.Forms.TextBox();
            this.BranchId_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Checkout_button = new System.Windows.Forms.Button();
            this.CheckoutBookId_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.checkinLastName = new System.Windows.Forms.TextBox();
            this.checkinSearch = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.check_in = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkinFirstName = new System.Windows.Forms.TextBox();
            this.checkinCardNo = new System.Windows.Forms.TextBox();
            this.checkinBookId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.borrowerphone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.borrowercity = new System.Windows.Forms.TextBox();
            this.addBorrower = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.borroweraddr1 = new System.Windows.Forms.TextBox();
            this.borrowerlname = new System.Windows.Forms.TextBox();
            this.borrowerfname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lIBRARYDataSet = new LibraryGUI.LIBRARYDataSet();
            this.lIBRARYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookcopiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_copiesTableAdapter = new LibraryGUI.LIBRARYDataSetTableAdapters.book_copiesTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryGUI.LIBRARYDataSetTableAdapters.bookTableAdapter();
            this.bookcopiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter book id: \r\n";
            // 
            // BookId_text
            // 
            this.BookId_text.Location = new System.Drawing.Point(143, 156);
            this.BookId_text.Name = "BookId_text";
            this.BookId_text.Size = new System.Drawing.Size(162, 20);
            this.BookId_text.TabIndex = 1;
            // 
            // FindBook_button
            // 
            this.FindBook_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FindBook_button.Location = new System.Drawing.Point(305, 217);
            this.FindBook_button.Name = "FindBook_button";
            this.FindBook_button.Size = new System.Drawing.Size(196, 23);
            this.FindBook_button.TabIndex = 2;
            this.FindBook_button.Text = "Find Book";
            this.FindBook_button.UseVisualStyleBackColor = false;
            this.FindBook_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 445);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Title_text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AuthorName_text);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BookId_text);
            this.tabPage1.Controls.Add(this.FindBook_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books Availability";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title_text
            // 
            this.Title_text.Location = new System.Drawing.Point(434, 178);
            this.Title_text.Name = "Title_text";
            this.Title_text.Size = new System.Drawing.Size(312, 20);
            this.Title_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // AuthorName_text
            // 
            this.AuthorName_text.Location = new System.Drawing.Point(434, 135);
            this.AuthorName_text.Name = "AuthorName_text";
            this.AuthorName_text.Size = new System.Drawing.Size(312, 20);
            this.AuthorName_text.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(291, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 69);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = " Enter at least one of the following and click \"Find Book\"\n   Book ID\n   Title of" +
    " the book\n    Author name\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ConfirmCheckOut_Button);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CardNo_text);
            this.tabPage2.Controls.Add(this.BranchId_text);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Checkout_button);
            this.tabPage2.Controls.Add(this.CheckoutBookId_text);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(897, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check out";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Review below items before confirming check out";
            this.label7.Visible = false;
            // 
            // ConfirmCheckOut_Button
            // 
            this.ConfirmCheckOut_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConfirmCheckOut_Button.Enabled = false;
            this.ConfirmCheckOut_Button.Location = new System.Drawing.Point(418, 231);
            this.ConfirmCheckOut_Button.Name = "ConfirmCheckOut_Button";
            this.ConfirmCheckOut_Button.Size = new System.Drawing.Size(196, 23);
            this.ConfirmCheckOut_Button.TabIndex = 12;
            this.ConfirmCheckOut_Button.Text = "Confirm check out";
            this.ConfirmCheckOut_Button.UseVisualStyleBackColor = false;
            this.ConfirmCheckOut_Button.Click += new System.EventHandler(this.ConfirmCheckOut_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(123, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 150);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.Visible = false;
            this.dataGridView2.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_RowValidating);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter the card number of the borrower:";
            // 
            // CardNo_text
            // 
            this.CardNo_text.Location = new System.Drawing.Point(282, 122);
            this.CardNo_text.Name = "CardNo_text";
            this.CardNo_text.Size = new System.Drawing.Size(139, 20);
            this.CardNo_text.TabIndex = 6;
            // 
            // BranchId_text
            // 
            this.BranchId_text.Location = new System.Drawing.Point(610, 66);
            this.BranchId_text.Name = "BranchId_text";
            this.BranchId_text.Size = new System.Drawing.Size(133, 20);
            this.BranchId_text.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter branch ID for the book:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Checkout_button
            // 
            this.Checkout_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Checkout_button.Location = new System.Drawing.Point(248, 187);
            this.Checkout_button.Name = "Checkout_button";
            this.Checkout_button.Size = new System.Drawing.Size(196, 23);
            this.Checkout_button.TabIndex = 3;
            this.Checkout_button.Text = "Show check out items";
            this.Checkout_button.UseVisualStyleBackColor = false;
            this.Checkout_button.Click += new System.EventHandler(this.Checkout_button_Click);
            // 
            // CheckoutBookId_text
            // 
            this.CheckoutBookId_text.Location = new System.Drawing.Point(282, 69);
            this.CheckoutBookId_text.Name = "CheckoutBookId_text";
            this.CheckoutBookId_text.Size = new System.Drawing.Size(139, 20);
            this.CheckoutBookId_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter book id to check out: \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.checkinLastName);
            this.tabPage3.Controls.Add(this.checkinSearch);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.checkinFirstName);
            this.tabPage3.Controls.Add(this.checkinCardNo);
            this.tabPage3.Controls.Add(this.checkinBookId);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(897, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check In";
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Enter last name of the borrower:";
            // 
            // checkinLastName
            // 
            this.checkinLastName.Location = new System.Drawing.Point(602, 107);
            this.checkinLastName.Name = "checkinLastName";
            this.checkinLastName.Size = new System.Drawing.Size(130, 20);
            this.checkinLastName.TabIndex = 18;
            // 
            // checkinSearch
            // 
            this.checkinSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkinSearch.Location = new System.Drawing.Point(382, 159);
            this.checkinSearch.Name = "checkinSearch";
            this.checkinSearch.Size = new System.Drawing.Size(196, 23);
            this.checkinSearch.TabIndex = 17;
            this.checkinSearch.Text = "Show results";
            this.checkinSearch.UseVisualStyleBackColor = false;
            this.checkinSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_in});
            this.dataGridView3.Location = new System.Drawing.Point(107, 199);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(731, 150);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.Visible = false;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // check_in
            // 
            this.check_in.HeaderText = "Check In";
            this.check_in.Name = "check_in";
            this.check_in.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check_in.Text = "Check In book";
            this.check_in.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(308, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter any of the below fields to start search  ";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Enter the card number of the borrower:";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enter first name of the borrower:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // checkinFirstName
            // 
            this.checkinFirstName.Location = new System.Drawing.Point(231, 111);
            this.checkinFirstName.Name = "checkinFirstName";
            this.checkinFirstName.Size = new System.Drawing.Size(130, 20);
            this.checkinFirstName.TabIndex = 12;
            // 
            // checkinCardNo
            // 
            this.checkinCardNo.Location = new System.Drawing.Point(602, 56);
            this.checkinCardNo.Name = "checkinCardNo";
            this.checkinCardNo.Size = new System.Drawing.Size(130, 20);
            this.checkinCardNo.TabIndex = 11;
            // 
            // checkinBookId
            // 
            this.checkinBookId.Location = new System.Drawing.Point(231, 59);
            this.checkinBookId.Name = "checkinBookId";
            this.checkinBookId.Size = new System.Drawing.Size(130, 20);
            this.checkinBookId.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Enter book id to check in:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.borrowerphone);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.borrowercity);
            this.tabPage4.Controls.Add(this.addBorrower);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.borroweraddr1);
            this.tabPage4.Controls.Add(this.borrowerlname);
            this.tabPage4.Controls.Add(this.borrowerfname);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(897, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Borrower";
            // 
            // label19
            // 
            this.label19.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(136, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Added borrower details:";
            this.label19.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(127, 259);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(643, 150);
            this.dataGridView4.TabIndex = 32;
            this.dataGridView4.Visible = false;
            // 
            // label18
            // 
            this.label18.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Phone";
            // 
            // borrowerphone
            // 
            this.borrowerphone.Location = new System.Drawing.Point(252, 169);
            this.borrowerphone.Name = "borrowerphone";
            this.borrowerphone.Size = new System.Drawing.Size(209, 20);
            this.borrowerphone.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "City, State*";
            // 
            // borrowercity
            // 
            this.borrowercity.Location = new System.Drawing.Point(661, 114);
            this.borrowercity.Name = "borrowercity";
            this.borrowercity.Size = new System.Drawing.Size(130, 20);
            this.borrowercity.TabIndex = 28;
            // 
            // addBorrower
            // 
            this.addBorrower.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addBorrower.Location = new System.Drawing.Point(332, 209);
            this.addBorrower.Name = "addBorrower";
            this.addBorrower.Size = new System.Drawing.Size(196, 23);
            this.addBorrower.TabIndex = 27;
            this.addBorrower.Text = "Add borrower";
            this.addBorrower.UseVisualStyleBackColor = false;
            this.addBorrower.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(329, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "*  - Required fields";
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Enter Borrower\'s last name*";
            // 
            // label16
            // 
            this.label16.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Address Line 1*";
            // 
            // borroweraddr1
            // 
            this.borroweraddr1.Location = new System.Drawing.Point(252, 121);
            this.borroweraddr1.Name = "borroweraddr1";
            this.borroweraddr1.Size = new System.Drawing.Size(209, 20);
            this.borroweraddr1.TabIndex = 23;
            // 
            // borrowerlname
            // 
            this.borrowerlname.Location = new System.Drawing.Point(661, 62);
            this.borrowerlname.Name = "borrowerlname";
            this.borrowerlname.Size = new System.Drawing.Size(130, 20);
            this.borrowerlname.TabIndex = 22;
            // 
            // borrowerfname
            // 
            this.borrowerfname.Location = new System.Drawing.Point(252, 69);
            this.borrowerfname.Name = "borrowerfname";
            this.borrowerfname.Size = new System.Drawing.Size(209, 20);
            this.borrowerfname.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Enter Borrower\'s first name*";
            // 
            // lIBRARYDataSet
            // 
            this.lIBRARYDataSet.DataSetName = "LIBRARYDataSet";
            this.lIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBRARYDataSetBindingSource
            // 
            this.lIBRARYDataSetBindingSource.DataSource = this.lIBRARYDataSet;
            this.lIBRARYDataSetBindingSource.Position = 0;
            // 
            // bookcopiesBindingSource
            // 
            this.bookcopiesBindingSource.DataMember = "book_copies";
            this.bookcopiesBindingSource.DataSource = this.lIBRARYDataSetBindingSource;
            // 
            // book_copiesTableAdapter
            // 
            this.book_copiesTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.lIBRARYDataSetBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookcopiesBindingSource1
            // 
            this.bookcopiesBindingSource1.DataMember = "book_copies";
            this.bookcopiesBindingSource1.DataSource = this.lIBRARYDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(547, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear selection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label20
            // 
            this.label20.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(500, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 16);
            this.label20.TabIndex = 34;
            this.label20.Text = "Generated card number:";
            this.label20.Visible = false;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(688, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 16);
            this.label21.TabIndex = 35;
            this.label21.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Click on row to check out";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Proceed to check out";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // LIBRARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "LIBRARY";
            this.Text = "MY LIBRARY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookId_text;
        private System.Windows.Forms.Button FindBook_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Title_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorName_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lIBRARYDataSetBindingSource;
        private LIBRARYDataSet lIBRARYDataSet;
        private System.Windows.Forms.BindingSource bookcopiesBindingSource;
        private LIBRARYDataSetTableAdapters.book_copiesTableAdapter book_copiesTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LIBRARYDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookcopiesBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Checkout_button;
        private System.Windows.Forms.TextBox CheckoutBookId_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardNo_text;
        private System.Windows.Forms.TextBox BranchId_text;
        private System.Windows.Forms.Button ConfirmCheckOut_Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox checkinFirstName;
        private System.Windows.Forms.TextBox checkinCardNo;
        private System.Windows.Forms.TextBox checkinBookId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button checkinSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox checkinLastName;
        private System.Windows.Forms.DataGridViewButtonColumn check_in;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox borrowerphone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox borrowercity;
        private System.Windows.Forms.Button addBorrower;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox borroweraddr1;
        private System.Windows.Forms.TextBox borrowerlname;
        private System.Windows.Forms.TextBox borrowerfname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

