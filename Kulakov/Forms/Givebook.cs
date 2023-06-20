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
    public partial class Givebook : Form
    {
        string formularId;
        public Givebook()
        {
            InitializeComponent();
        }
        public Givebook(string fId)
        {
            InitializeComponent();
            formularId = fId;
            TbNumberReaders.Text = formularId;
        }
        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            LbAutorBook.Text = "*";
            LbFIO.Text = "*";
            LbFolmularBook.Text = "*";
            LbGroup.Text = "*";
            LbNameBook.Text = "*";
            LbNumberBook.Text = "*";
            LbPhone.Text = "*";

            TbCopyBook.Clear();
            TbDays.Clear();
            TbNumberReaders.Clear();
        }

        private void TbCopyBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //using (SqlConnection SqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True"))
            //{
            //    SqlConn.Open();
            //    //SqlCommand cmd = new SqlCommand("Insert into Readers(Readers_FirstMiddleLastName, Readers_Birthday, Readers_BlackList, Readers_DateRegistration, Readers_Informations, Readers_Passport, Readers_Phone, Readers_Street) Values ('" + TbFamily.Text + "', '"+DateTimePicker.Text+"', 0, CONVERT(date, GETDATE(), 101), '" + TbDescription.Text + "', '" + TbName.Text + "', '" + TbOthestvo.Text + "', '" + TbStudentGroup.Text + "');", SqlConn);
            //    SqlCommand cmd = new SqlCommand("Select * from Book Where Book.bId LIKE '%"+comboBox1.Text+"%'", SqlConn);
            //    SqlDataReader dataAdapter = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(dataAdapter);
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        comboBox1.Items.Add(row["bId"]);
            //    }
            //    SqlConn.Close();
            //}
        }

        private void BtCheck_Click(object sender, EventArgs e)
        {
            string fId = TbNumberReaders.Text;
            string bId = TbCopyBook.Text;

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
            {
                //Select * From Formular Where formularId = 1
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Formular Where formularId = "+fId+"", sqlConn);

                SqlDataReader dataAdapter = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataAdapter);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        LbFolmularBook.Text = row["formularId"].ToString();
                        LbFIO.Text = row["FIO"].ToString(); //StudentGroup Phone
                        LbGroup.Text = row["StudentGroup"].ToString();
                        LbPhone.Text = row["Phone"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Формуляр с таким номером не был найден!");
                }
                sqlConn.Close();
            }
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
            {
                //Select * From Formular Where formularId = 1
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Book inner join Autor On Book.AutorFK = Autor.aId Where bId = " + TbCopyBook.Text+"",sqlConn);

                SqlDataReader dataAdapter = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataAdapter);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        LbNumberBook.Text = row["bId"].ToString(); //StudentGroup Phone
                        LbNameBook.Text = row["bName"].ToString();
                        LbAutorBook.Text = row["aName"].ToString();

                    }
                }
                else {
                    MessageBox.Show("Книги с таким номером не было найдено!");
                }
                sqlConn.Close();
            }

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int numberBook = Convert.ToInt32(TbCopyBook.Text);
                int numberFormular = Convert.ToInt32(TbNumberReaders.Text);
                int day = Convert.ToInt32(TbDays.Text);


                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select Book.bId, Book.bAccess From Book Where Book.bId = "+numberBook+"",conn);
                    SqlDataReader sdr =  cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    if (dt.Rows.Count >= 1)
                    {
                        string querybookid = "";
                        bool querybookstatus = default;
                        foreach (DataRow rows in dt.Rows)
                        {
                            querybookid = rows["bId"].ToString();
                            querybookstatus = Convert.ToBoolean(rows["bAccess"]);
                            
                        }
                        if (querybookstatus == true)
                        {
                            // givebook           Insert into GiveBook (giveDate, giveDay, bookFK, formularFK) VALUES (GETDATE(), 15, 101, 2);
                            cmd.CommandText = "Insert into GiveBook (giveDate, giveDay, bookFK, formularFK) VALUES (GETDATE(), '"+TbDays.Text+"', "+querybookid+", "+numberFormular+");";
                            int countRow =  cmd.ExecuteNonQuery();
                            if (countRow >= 1)
                            {
                                cmd.CommandText = "Update Book SET bAccess = 0,bStellazh = '' Where bId = " + querybookid + "";
                                int count = cmd.ExecuteNonQuery();
                                if (count >= 1)
                                {
                                    MessageBox.Show("Заказ оформлен");
                                }
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Данная книга уже находиться в прокате!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Книги с таким номером не было найдено!");
                    }
                    conn.Close();
                    // check    select Book.bId, Book.bAccess From Book Where Book.bId = 101
                }
            }
            catch (Exception ex)
            {
                DialogResult result =  MessageBox.Show("Что-то пошло не так! Посмотреть информацию ?", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    MessageBox.Show(ex.ToString());
            }
        }

        private void Givebook_Load(object sender, EventArgs e)
        {
              
        }
    }
}
