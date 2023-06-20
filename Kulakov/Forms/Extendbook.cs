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
    public partial class Extendbook : Form
    {
        public Extendbook()
        {
            InitializeComponent();
        }
        int day = 0;
        private void Extendbook_Load(object sender, EventArgs e)
        {

        }

        private void BGetInfo_Click(object sender, EventArgs e)
        {
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
                        day = Convert.ToInt32(rows["giveDay"]);
                    }

                }

            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            int days = day + Convert.ToInt32(TbDays.Text);
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update GiveBook Set giveDay = "+TbDays.Text+" where bookFK = "+TbBook.Text+";", conn);
                int count = cmd.ExecuteNonQuery();
                if (count >= 1)
                    MessageBox.Show("Срок возврата книги продлен!");
            }
        }
    }
}
