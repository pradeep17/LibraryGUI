using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace LibraryGUI
{
       
    public partial class Form1 : Form
    {
        SqlConnection cnsql;
        SqlCommand cmsql = new SqlCommand();
        String checkout_bookid;
        String checkout_branchid;
        String checkout_cardno;
        String SQL_CONNECTION_STRING = ConfigurationManager.AppSettings["SQL_CONNECTION_STRING"].ToString();
        
        //getters and setters

        public void setbookid(String text)
        {
            checkout_bookid= text;
        }
         public void setbranchid(String text)
        {
            checkout_branchid= text;
        }
         public void setcardno(String text)
        {
            checkout_cardno= text;
        }
        public String getbookid()
        {
            return checkout_bookid;
        }
        public String getbranchid()
        {
            return checkout_branchid;
        }
        public String getcardno()
        {
            return checkout_cardno;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String book_id = Convert.ToString(BookId_text.Text);
            String author = Convert.ToString(AuthorName_text.Text);
            String title = Convert.ToString(Title_text.Text);
           
            if (book_id == "" && author == "" && title == "")
                MessageBox.Show("Please enter a value for Book Id or Author or Title");
            else
            {
                if (book_id == "")
                    book_id = "%%";

                CreateConnection();
                getData(book_id, author, title);
                CloseConnection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CreateConnection();
            
        }

        
        private void CreateConnection()
        {
            cnsql = new SqlConnection(SQL_CONNECTION_STRING);
            try
            {
                cnsql.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Sql Error");
            }
        }
        private void CloseConnection()
        {
            
            try
            {
                cnsql.Close();               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Sql Error");
            }
        }
        private void getData(String book_id, String author, String title)
        {
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "select b.Book_id,bc.Branch_id,bc.No_of_copies as Total_copies,(bc.No_of_copies -(select count(*) from BOOK_LOANS bl,BOOK b, BOOK_COPIES bc,BOOK_AUTHORS ba where bl.Book_id=b.Book_id and ba.Book_id=b.Book_id and bc.Book_id=b.Book_id and (b.Title like '%" + title + "%' AND b.Book_id LIKE '" + book_id + "' AND ba.Author_name like '%" + author + "%'))) as Available_copies  from BOOK b, BOOK_COPIES bc,BOOK_AUTHORS ba where  ba.Book_id=b.Book_id and bc.Book_id=b.Book_id and (b.Title like '%" + title + "%' AND b.Book_id LIKE '" + book_id + "' AND ba.Author_name like '%" + author + "%')";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                 
                if(ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No values were returned for the search! Please retry");
                else
                    dataGridView1.DataSource = ds.Tables[0];
                
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
            catch (Exception genex)
            {
                MessageBox.Show(genex.Message, "Exception caught due to invalid entries. Please re enter details and retry");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_button_Click(object sender, EventArgs e)
        {
            String book_id = Convert.ToString(CheckoutBookId_text.Text);
            String branch_id = Convert.ToString(BranchId_text.Text);
            String card_no = Convert.ToString(CardNo_text.Text);

            if (book_id == "" || branch_id == "" || card_no == "")
                MessageBox.Show("Please enter a value for Book Id, Branch ID and Card number");
            else
            {
                   CreateConnection();
            getcheckoutdetails(book_id, branch_id, card_no);
                CloseConnection();
            }

        }
        private void getcheckoutdetails(String book_id, String branch_id, String card_no)
        {
           
             try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "select bo.card_no as Card_Number,bo.fname+' ' +bo.lname as Borrower_Name,b.Book_id,bc.Branch_id,bc.No_of_copies as Total_copies,(bc.No_of_copies -(select count(*) from (BOOK_LOANS bl inner join BOOK b on bl.Book_id=b.Book_id) inner join BOOK_COPIES bc on bc.Book_id=b.Book_id and b.Book_id = '" + book_id + "' and bc.Branch_id = '" + branch_id + "')) as Available_copies  from (BOOK b inner join BOOK_COPIES bc on bc.Book_id=b.Book_id) inner join borrower bo on bo.card_no ='" + card_no + "' where b.Book_id = '" + book_id + "' and bc.Branch_id = '" + branch_id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No values were returned for the search! Please retry");
                else
                {
                    label7.Visible = true;
                    dataGridView2.DataSource = ds.Tables[0];
                    ConfirmCheckOut_Button.Enabled = true;
                    setbookid(book_id);
                    setbranchid(branch_id);
                    setcardno(card_no);
                }
           
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
            catch (Exception genex)
            {
                MessageBox.Show(genex.Message, "Exception caught due to invalid entries. Please re enter details and retry");
            }

        }

        private void ConfirmCheckOut_Button_Click(object sender, EventArgs e)
        {
            CreateConnection();
            insertCheckoutdata();
            CloseConnection();
        }
        private void insertCheckoutdata()
        {
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "INSERT INTO book_loans VALUES('" + getbookid() + "','" + getbranchid() + "','" + getcardno() + "',GETDATE(),GETDATE() + 14)";
                cmsql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while inserting:" + ex.Message, "Sql Error");
            }
            catch (Exception genex)
            {
                MessageBox.Show(genex.Message, "Exception caught while inserting data");
            }
        }
    }
}
