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
        
        String SQL_CONNECTION_STRING = ConfigurationManager.AppSettings["SQL_CONNECTION_STRING"].ToString();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String book_id = Convert.ToString(textBox1.Text);
            String author = Convert.ToString(textBox3.Text);
            String title = Convert.ToString(textBox4.Text);
            if (book_id == "")
                book_id = "%%";
            if (book_id == "" && author == "" && title == "")
                MessageBox.Show("Please enter a value for Book Id or Author or Title");
            else
            {
                getData(book_id, author, title);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CreateConnection();
            
        }

     
        public void CreateConnection()
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
        public void getData(String book_id, String author, String title)
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
                dataGridView1.DataSource = ds.Tables[0];
               
                cnsql.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
            catch (Exception genex)
            {
                MessageBox.Show(genex.Message, "Exception caught due to invalid entries");
            }
        }
    }
}
