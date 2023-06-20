using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulakov.Forms
{
    public partial class BookAccess : Form
    {
        public BookAccess()
        {
            InitializeComponent();
        }

        private void BookAccess_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.YesBook". При необходимости она может быть перемещена или удалена.
            this.yesBookTableAdapter.Fill(this.kulakovLBDataSet.YesBook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.YesBook". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Book". При необходимости она может быть перемещена или удалена.

            // Select bId, bName, bAutor, bPublisher, pStellazh From Book Where bAccess = 1
            //using (SqlConnection SqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True"))
            //{

            //    SqlConn.Open();
            //    //SqlCommand cmd = new SqlCommand("Insert into Readers(Readers_FirstMiddleLastName, Readers_Birthday, Readers_BlackList, Readers_DateRegistration, Readers_Informations, Readers_Passport, Readers_Phone, Readers_Street) Values ('" + TbFamily.Text + "', '"+DateTimePicker.Text+"', 0, CONVERT(date, GETDATE(), 101), '" + TbDescription.Text + "', '" + TbName.Text + "', '" + TbOthestvo.Text + "', '" + TbStudentGroup.Text + "');", SqlConn);
            //    SqlCommand cmd = new SqlCommand("Select bId, bName, bAutor, bPublisher, pStellazh From Book Where bAccess = 1", SqlConn);
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    dataAdapter.Fill(ds);

            //    //BindingSource bs = new BindingSource();
            //    //bs.DataSource = dataAdapter.Fill(ds);

            //    dataGridView1.DataSource = ds.Tables[0];
            //    dataGridView1.ReadOnly = true;
            //    dataGridView1.Select();
            //    SqlConn.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RbName.Checked == true)
            {
                yesBookBindingSource1.Filter = "bName Like '%" + textBox1.Text + "%'";
            }
            else if (RbAutor.Checked == true)
            {
                yesBookBindingSource1.Filter = "aName Like '%" + textBox1.Text + "%'";
            }
            else if (RbGenry.Checked == true)
            {
                yesBookBindingSource1.Filter = "gName Like '%" + textBox1.Text + "%'";
            }
            else if (RbPublic.Checked == true)
            {
                yesBookBindingSource1.Filter = "pName Like '%" + textBox1.Text + "%'";
            }
        }
    }
}
