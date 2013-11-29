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
        int checkout_availableCopies;
        int count_borrowed;
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
         public void setavailableCopies(int value)
         {
             checkout_availableCopies = value;
         }
         public void setcount(int value)
         {
             count_borrowed = value;
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
         public int getavailableCopies()
        {
            return checkout_availableCopies;
        }
          public int getcount()
        {
            return count_borrowed;
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
                cmsql.CommandText = "SELECT b.Book_id,b.title,ba.Author_name,bc.Branch_id,bc.No_of_copies AS Total_copies,(bc.No_of_copies - COUNT(bl.book_id)) AS Available_copies FROM ((BOOK b INNER JOIN BOOK_COPIES bc ON bc.Book_id =b.Book_id) INNER JOIN BOOK_AUTHORS ba ON ba.Book_id= b.Book_id) LEFT JOIN BOOK_LOANS bl  ON  bl.Book_id=b.Book_id AND bl.Branch_id = bc.Branch_id WHERE b. Title like '%" + title + "%' AND b.Book_id like '" + book_id + "' AND ba.Author_name like '%" + author + "%' GROUP BY b.Book_id, b.title ,ba.Author_name,bc.Branch_id, bc.No_of_copies, bl.book_id";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No values were returned for the search! Please retry");
                else
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Visible = true;
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
            getborrowerbookcount(card_no);
                CloseConnection();
            }

        }
        private void getcheckoutdetails(String book_id, String branch_id, String card_no)
        {
           
             try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT bo.card_no,bo.fname+ ' ' +bo.lname AS Borrower_Name,b.Book_id,bc.Branch_id,bc.No_of_copies AS Total_copies,(bc.No_of_copies - COUNT(bl.book_id)) AS Available_copies  FROM (((BOOK b INNER JOIN BOOK_COPIES bc ON bc.Book_id=b.Book_id) INNER JOIN borrower bo ON bo.card_no ='" + card_no + "') LEFT JOIN BOOK_LOANS bl ON  bl.Book_id=b.Book_id AND bl.Branch_id = bc.Branch_id) WHERE b.Book_id = '" + book_id + "' and bc.Branch_id = '" + branch_id + "' GROUP BY bo.card_no,bo.fname,bo.lname,b.Book_id,bc.Branch_id,bc.No_of_copies";
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
                    dataGridView2.Visible = true;
                    ConfirmCheckOut_Button.Enabled = true;
                    setbookid(book_id);
                    setbranchid(branch_id);
                    setcardno(card_no);

                    SqlDataReader sdr = cmsql.ExecuteReader();
                    while (sdr.Read())
                    {
                        setavailableCopies(Convert.ToInt16(sdr["Available_copies"]));
                    }
                    sdr.Close();
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

        private void getborrowerbookcount(String card_no)
        {

            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT COUNT(card_no) as Count_borrowed FROM BOOK_LOANS WHERE CARD_NO = '" + card_no + "'";


                SqlDataReader sdr = cmsql.ExecuteReader();
                while (sdr.Read())
                {
                    setcount(Convert.ToInt16(sdr["Count_borrowed"]));
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
            if (getavailableCopies() <= 0)
            {
                MessageBox.Show("Out of stock for this Library Branch : No more book copies are available at this Library Branch to check out");
            }
            else
            {
                if (count_borrowed >= 3)
                {
                    MessageBox.Show("Error : The book cannot be checked out.\n The borrower has reached the limit(3 books per borrower). Number of books borrowed: " + count_borrowed);
                }
                else
                {
                    insertCheckoutdata();
                    displaycheckoutsummary();
                }
            }
            CloseConnection();

        }
        private void displaycheckoutsummary()
        {

            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT book_id,branch_id,card_no,CONVERT(varchar(10),date_out,101) AS DATE_OUT,CONVERT(varchar(10),due_date,101) AS DUE_DATE FROM BOOK_LOANS where book_id = '"+ getbookid() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No values were returned for the search! Please retry");
                else
                {
                    label7.Text  = "Check out summary:";
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView2.Visible = true;
                    
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

        private void insertCheckoutdata()
        {
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "INSERT INTO book_loans VALUES('" + getbookid() + "','" + getbranchid() + "','" + getcardno() + "',GETDATE(),GETDATE() + 14)";
                cmsql.ExecuteNonQuery();
                MessageBox.Show("This transaction has been successfully updated for the borrower");
                ConfirmCheckOut_Button.Enabled = false;

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("This borrower has been issued a similar book from the same Library branch.\nPlease select a different book \n\n ", "Duplicate found");
                else
                    MessageBox.Show("Error while inserting:" + ex.Message, "Sql Error");
            }
            catch (Exception genex)
            {
                MessageBox.Show(genex.Message, "Exception caught while inserting data");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                String card_no = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                String book_id = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
                String branch_id = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                CreateConnection();
                deleteCheckinData(book_id, branch_id);
                showCheckInResults(book_id, card_no, "", "");
                CloseConnection();
            }

        }
        private void deleteCheckinData(String book_id, String branch_id)
        {
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "DELETE FROM book_loans WHERE book_id = '" + book_id + "' and branch_id = '" + branch_id + "'";
                cmsql.ExecuteNonQuery();
                MessageBox.Show("This transaction has been successfully updated for the borrower");
                

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            String book_id = Convert.ToString(checkinBookId.Text);
            String card_no = Convert.ToString(checkinCardNo.Text);
            String fname = Convert.ToString(checkinFirstName.Text);
            String lname = Convert.ToString(checkinLastName.Text);
            dataGridView3.Visible = false;
            if (book_id == "" && card_no == "" && fname == "" && lname == "")
                MessageBox.Show("Please enter a value for any of the fields to begin search");
            else
            {
                if (book_id == "")
                    book_id = "%%";
                if (card_no == "")
                    card_no = "%%";

                CreateConnection();
                showCheckInResults(book_id, card_no, fname, lname);
                CloseConnection();
            }
        }

        private void showCheckInResults(String book_id, String card_no, String fname, String lname)
        {
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT bo.fname,bo.lname,bl.card_no,bl.book_id,bl.branch_id,bl.due_date FROM BOOK_LOANS bl INNER JOIN BORROWER bo ON bo.card_no = bl.card_no WHERE bl.card_no LIKE '" + card_no + "' AND bo.fname LIKE '%" + fname + "%' AND bo.lname LIKE '%" + lname + "%' AND bl.book_id LIKE '" + book_id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                             
                    dataGridView3.DataSource = ds.Tables[0];
                    dataGridView3.Visible = true;

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No borrowed books were found! Please retry");

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            String bofname = Convert.ToString(borrowerfname.Text);
            String bolname = Convert.ToString(borrowerlname.Text);
            String boaddr1 = Convert.ToString(borroweraddr1.Text);
            String bocity = Convert.ToString(borrowercity.Text);
            String bophone = Convert.ToString(borrowerphone.Text);

            String boaddr = boaddr1 + ", " + bocity;
            dataGridView3.Visible = false;
            if (bofname == "" || bolname == "" || boaddr1 == "" || bocity == "")
                MessageBox.Show("Please enter a value for the required fields");
            
            else
            {
                if (bophone == "")
                    bophone = null;

                CreateConnection();
                insertBorrower(bofname, bolname, boaddr, bophone);
                CloseConnection();
            }
        }

        private void insertBorrower(String bofname, String bolname, String boaddr, String bophone)
        {
            String card_no = null;
            bool valid = true;
            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT fname,lname,address FROM borrower";
                SqlDataReader sdr = cmsql.ExecuteReader();
                while (sdr.Read())
                {
                    if (bofname == Convert.ToString(sdr["fname"]) && bolname == Convert.ToString(sdr["lname"]) && boaddr == Convert.ToString(sdr["address"]))
                    {
                        MessageBox.Show("An entry with the same borrower's name and address already exists in the database.\n The borrower cannot be added.");
                        valid = false;
                    }
                }
                sdr.Close();
                if (valid)
                {
                    cmsql.CommandText = "INSERT INTO borrower VALUES((SELECT MAX(card_no)+1 FROM borrower), '" + bofname + "','" + bolname + "','" + boaddr + "','" + bophone + "')";
                    cmsql.ExecuteNonQuery();
                    MessageBox.Show("This transaction has been successfully updated for the borrower");
                }

                cmsql.CommandText = "SELECT MAX(card_no) as cardno FROM borrower";
                 sdr = cmsql.ExecuteReader();
                 while (sdr.Read())
                 {
                     card_no = Convert.ToString(sdr["cardno"]);
                 }
                 sdr.Close();
                 showaddedborrower(card_no);
                
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

        private void showaddedborrower(String card_no)
        {

            try
            {

                cmsql.Connection = cnsql;
                cmsql.CommandText = "SELECT * FROM borrower where card_no = '" + card_no + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmsql);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No values were returned for the search! Please retry");
                else
                {
                    
                    dataGridView4.DataSource = ds.Tables[0];
                    label19.Visible = true;
                    dataGridView4.Visible = true;

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
    }
}
