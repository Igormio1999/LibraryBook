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
    public partial class AddReaders : Form
    {
        public AddReaders()
        {
            InitializeComponent();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 15;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить все поля?", "стереть поля", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            progressBar1.Value = 45;
            if (DialogResult.Yes == result)
            {
                TbFIO.Text = "";
                comboBox1.Text = "";
                TbPhone.Text = "";
                //TbGroup.Text = "";
                //TbYeat.Text = "";
                progressBar1.Value = 100;
            }
            progressBar1.Value = 0;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            
            if (TbFIO.Text == string.Empty && TbPhone.Text == string.Empty && comboBox1.Text == string.Empty && dateTimePicker1.Text == string.Empty)
                MessageBox.Show("Не все поля заполнены, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить нового читателя ?", "Добавить читателя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection SqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                    {
                        int count = -1;
                        SqlConn.Open();
                        //SqlCommand cmd = new SqlCommand("Insert into Readers(Readers_FirstMiddleLastName, Readers_Birthday, Readers_BlackList, Readers_DateRegistration, Readers_Informations, Readers_Passport, Readers_Phone, Readers_Street) Values ('" + TbFamily.Text + "', '" + DateTimePicker.Text + "', 0, CONVERT(date, GETDATE(), 101), '" + TbDescription.Text + "', '" + TbName.Text + "', '" + TbOthestvo.Text + "', '" + TbStudentGroup.Text + "');", SqlConn);
                        SqlCommand cmd = new SqlCommand("Insert into Formular (FIO, Phone ,StudentGroup,Year) Values ('" + TbFIO.Text + "', '" + TbPhone.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "');", SqlConn);
                        count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                            MessageBox.Show("Запись добавлена!");
                        SqlConn.Close();
                    }

                }


            }

        }
    }
}
