namespace LibraryGUI
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lIBRARYDataSet = new LibraryGUI.LIBRARYDataSet();
            this.lIBRARYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookcopiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_copiesTableAdapter = new LibraryGUI.LIBRARYDataSetTableAdapters.book_copiesTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryGUI.LIBRARYDataSetTableAdapters.bookTableAdapter();
            this.bookcopiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CheckoutBookId_text = new System.Windows.Forms.TextBox();
            this.Checkout_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BranchId_text = new System.Windows.Forms.TextBox();
            this.CardNo_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ConfirmCheckOut_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter book id: \r\n";
            // 
            // BookId_text
            // 
            this.BookId_text.Location = new System.Drawing.Point(195, 84);
            this.BookId_text.Name = "BookId_text";
            this.BookId_text.Size = new System.Drawing.Size(100, 20);
            this.BookId_text.TabIndex = 1;
            // 
            // FindBook_button
            // 
            this.FindBook_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FindBook_button.Location = new System.Drawing.Point(184, 161);
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
            this.label3.Location = new System.Drawing.Point(351, 87);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 445);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Title_text
            // 
            this.Title_text.Location = new System.Drawing.Point(87, 127);
            this.Title_text.Name = "Title_text";
            this.Title_text.Size = new System.Drawing.Size(312, 20);
            this.Title_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // AuthorName_text
            // 
            this.AuthorName_text.Location = new System.Drawing.Point(434, 84);
            this.AuthorName_text.Name = "AuthorName_text";
            this.AuthorName_text.Size = new System.Drawing.Size(259, 20);
            this.AuthorName_text.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(90, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 72);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = " Enter at least one of the following and click \"Find Book\"\n   Book ID\n   Title of" +
    " the book\n    Author name\n";
            // 
            // tabPage2
            // 
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
            this.tabPage2.Text = "Check in/check out books";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(908, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add a borrower";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // CheckoutBookId_text
            // 
            this.CheckoutBookId_text.Location = new System.Drawing.Point(214, 69);
            this.CheckoutBookId_text.Name = "CheckoutBookId_text";
            this.CheckoutBookId_text.Size = new System.Drawing.Size(100, 20);
            this.CheckoutBookId_text.TabIndex = 2;
            // 
            // Checkout_button
            // 
            this.Checkout_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Checkout_button.Location = new System.Drawing.Point(100, 185);
            this.Checkout_button.Name = "Checkout_button";
            this.Checkout_button.Size = new System.Drawing.Size(196, 23);
            this.Checkout_button.TabIndex = 3;
            this.Checkout_button.Text = "Check Out";
            this.Checkout_button.UseVisualStyleBackColor = false;
            this.Checkout_button.Click += new System.EventHandler(this.Checkout_button_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter branch ID for the book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BranchId_text
            // 
            this.BranchId_text.Location = new System.Drawing.Point(529, 66);
            this.BranchId_text.Name = "BranchId_text";
            this.BranchId_text.Size = new System.Drawing.Size(100, 20);
            this.BranchId_text.TabIndex = 5;
            // 
            // CardNo_text
            // 
            this.CardNo_text.Location = new System.Drawing.Point(303, 125);
            this.CardNo_text.Name = "CardNo_text";
            this.CardNo_text.Size = new System.Drawing.Size(130, 20);
            this.CardNo_text.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter the card number of the borrower";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(248, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(474, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // ConfirmCheckOut_Button
            // 
            this.ConfirmCheckOut_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConfirmCheckOut_Button.Enabled = false;
            this.ConfirmCheckOut_Button.Location = new System.Drawing.Point(46, 260);
            this.ConfirmCheckOut_Button.Name = "ConfirmCheckOut_Button";
            this.ConfirmCheckOut_Button.Size = new System.Drawing.Size(196, 23);
            this.ConfirmCheckOut_Button.TabIndex = 12;
            this.ConfirmCheckOut_Button.Text = "Confirm check out";
            this.ConfirmCheckOut_Button.UseVisualStyleBackColor = false;
            this.ConfirmCheckOut_Button.Click += new System.EventHandler(this.ConfirmCheckOut_Button_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Review below items before confirming check out";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookcopiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
    }
}

