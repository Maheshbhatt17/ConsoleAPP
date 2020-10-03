using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //open the connection 
            string connectionstring = "Data Source=.\\SQLEXPRESS;Initial Catalog=Databasefirstdemo;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            // fire the command
            SqlCommand objcmd = new SqlCommand("Select * from Posts", con);
            DataSet objset = new DataSet();
            SqlDataAdapter objadptr = new SqlDataAdapter(objcmd);
            objadptr.Fill(objset);

            //bind the data to UI
            dataGridView1.DataSource = objset.Tables[0];

            //close the conncection
            con.Close();
        }
    }
}
