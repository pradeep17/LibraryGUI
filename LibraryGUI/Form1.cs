using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryGUI
{
    public partial class Form1 : Form
    {
        SqlConnection cnsql;
        SqlCommand cmsql;
        SqlDataReader drsql;
        String strsql;
        String SQL_CONNECTION_STRING = ConfigurationManager.AppSettings["SQL_CONNECTION_STRING"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                String book_id = Convert.ToString(textBox1.Text);
                strsql = "SELECT Title from BOOK where Book_id = '" +  book_id + "'";
                cmsql = new SqlCommand(strsql, cnsql);
                drsql = cmsql.ExecuteReader();
                while (drsql.Read())
                {
                    textBox2.Text = drsql.GetValue(0).ToString();
                }
                cnsql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message, "Sql Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
