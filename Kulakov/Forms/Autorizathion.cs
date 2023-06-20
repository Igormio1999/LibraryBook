using Kulakov.Forms;
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

namespace Kulakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id = -1;
        int role = -1;
        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtLogins_Click(object sender, EventArgs e)
        {
            if (TbLogin.Text == string.Empty && TbPassword.Text == string.Empty)
                MessageBox.Show("Поле логина или пароля не заполнено!");
            else
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("Select [eId],[eRole] From [Employee] Where [eLogin] = '"+TbLogin.Text+ "' AND [ePassword] = '"+TbPassword.Text+"'", sqlConn);
                    SqlDataReader sdr =  cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    foreach (DataRow row in dt.Rows)
                    {
                        id = Convert.ToInt32(row["eId"]);
                        role = Convert.ToInt32(row["eRole"]);
                    }
                    sqlConn.Close();
                    switch (role)
                    {
                        case 100:
                            MessageBox.Show("Добро пожаловать! Дата вашего входа: "+DateTime.Now, "Пользователь");
                            MainForm fMain = new MainForm(id, role);
                            fMain.Show();
                            this.Hide();
                            break;
                        case 101:
                            DialogResult result = MessageBox.Show("Добро пожаловать! Дата вашего входа: " + DateTime.Now + "Перейти к панели администратора?", "Администратор", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) { }
                            //Admin
                            else
                            {

                            }
                                    // User
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
