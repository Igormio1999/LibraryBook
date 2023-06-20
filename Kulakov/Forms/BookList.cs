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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.kulakovLBDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.kulakovLBDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.FullBook". При необходимости она может быть перемещена или удалена.
            this.fullBookTableAdapter.Fill(this.kulakovLBDataSet.FullBook);
            //using (SqlConnection SqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True"))
            //{
            //    int count = -1;
            //    SqlConn.Open();
            //    //SqlCommand cmd = new SqlCommand("Insert into Readers(Readers_FirstMiddleLastName, Readers_Birthday, Readers_BlackList, Readers_DateRegistration, Readers_Informations, Readers_Passport, Readers_Phone, Readers_Street) Values ('" + TbFamily.Text + "', '"+DateTimePicker.Text+"', 0, CONVERT(date, GETDATE(), 101), '" + TbDescription.Text + "', '" + TbName.Text + "', '" + TbOthestvo.Text + "', '" + TbStudentGroup.Text + "');", SqlConn);
            //    SqlCommand cmd = new SqlCommand("Select bId, bName, bAutor, bPublisher, pStellazh From Book", SqlConn);
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    dataAdapter.Fill(ds);

            //    dataGridView1.DataSource = ds.Tables[0];
            //    dataGridView1.ReadOnly = true;
            //    dataGridView1.Select();

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RbName.Checked == true)
            {
                bookBindingSource.Filter = "bName Like '%" + textBox1.Text + "%'";
            }
            else if (RbId.Checked == true)
            {
                int number = Convert.ToInt32(textBox1.Text);
                bookBindingSource.Filter = "bId = "+number+"";
            }
            
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Обновить таблицу данных ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                this.bookTableAdapter.Fill(this.kulakovLBDataSet.Book);
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения в таблице данных ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookTableAdapter.Update(this.kulakovLBDataSet.Book);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookBindingSource.Filter = "";
        }
    }
}
