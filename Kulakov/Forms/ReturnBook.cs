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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void TbCopyBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (TbBook.Text == string.Empty && TbStellazh.Text == string.Empty)
                MessageBox.Show("Введите номер экземпляра и номер стелажа");
            else
            {
                int bookId = -1;
                int formularId = -1;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                {
                    //select * from GiveBook where bookFK = 101
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from GiveBook where bookFK = "+TbBook.Text+"", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);

                    if (dt.Rows.Count >= 1)
                    {
                        foreach (DataRow rows in dt.Rows)
                        {
                            rows["giveId"].ToString();
                            bookId     =    Convert.ToInt32(rows["bookFK"]);
                            formularId =    Convert.ToInt32(rows["formularFK"]);
                        }
                        cmd.CommandText = "Insert into ReturnBook (returnDate, bookFK, formularFK) VALUES (GETDATE(), " + bookId + ", " + formularId + ");";
                        int count =  cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            cmd.CommandText = "Update Book SET bAccess = 1,bStellazh = '"+TbStellazh.Text+"' Where bId = " + bookId + "";
                            int countt = cmd.ExecuteNonQuery();
                            if (count >= 1)
                            {
                                MessageBox.Show("Книга  возвращена");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Информации по данному экземпляру нет!");
                    }
                }
            }
        }

        private void BGetInfo_Click(object sender, EventArgs e)
        {
            if (TbBook.Text == string.Empty)
                MessageBox.Show("Заполните поле номера формуляра!");
            else
            {
                // select giveId, giveDate, giveDay, bId, bName from GiveBook inner join Book ON Book.bId = GiveBook.bookFK where bAccess = 0 AND bId = 101;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select giveId, giveDate, giveDay, bId, bName from GiveBook inner join Book ON Book.bId = GiveBook.bookFK where bAccess = 0 AND bId = " + TbBook.Text + ";", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    if (dt.Rows.Count >= 1)
                    {
                        foreach (DataRow rows in dt.Rows)
                        {
                            LbGiveDate.Text = rows["giveDate"].ToString();
                            LbCountDay.Text = rows["giveDay"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет информации по данному экземпляру!");
                    }
                }
            }
        }
    }
}
