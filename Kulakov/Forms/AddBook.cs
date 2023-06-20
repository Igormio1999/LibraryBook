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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (TbName.Text == string.Empty && TbStellazh.Text == string.Empty && CbAutor.Text == string.Empty && CbGenry.Text == string.Empty && CbPublisher.Text == string.Empty)
                MessageBox.Show("Не все поля заполнены, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить новую книгу ?", "Добавить книгу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection SqlConn = new SqlConnection(@"Data Source=DESKTOP-RA96CSE\SQLEXPRESS;Initial Catalog=KulakovLB;Integrated Security=True"))
                    {
                        int count = -1;
                        int aId = Convert.ToInt32(autorId.Text);
                        int gId = Convert.ToInt32(GenryId.Text);
                        int pId = Convert.ToInt32(Publd.Text);
                        SqlConn.Open();
                        //SqlCommand cmd = new SqlCommand("Insert into Readers(Readers_FirstMiddleLastName, Readers_Birthday, Readers_BlackList, Readers_DateRegistration, Readers_Informations, Readers_Passport, Readers_Phone, Readers_Street) Values ('" + TbFamily.Text + "', '"+DateTimePicker.Text+"', 0, CONVERT(date, GETDATE(), 101), '" + TbDescription.Text + "', '" + TbName.Text + "', '" + TbOthestvo.Text + "', '" + TbStudentGroup.Text + "');", SqlConn);
                        SqlCommand cmd = new SqlCommand("Insert into Book (bName, bStellazh, bAccess, AutorFK, GenryFK, PublisherFK) VALUES ('"+TbName.Text+"', '"+TbStellazh.Text+"', 1, "+aId+","+gId+","+pId+");", SqlConn);
                        count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                            MessageBox.Show("Запись добавлена!");
                        SqlConn.Close();
                    }

                }


            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Autor". При необходимости она может быть перемещена или удалена.
            this.autorTableAdapter.Fill(this.kulakovLBDataSet.Autor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.kulakovLBDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Genry". При необходимости она может быть перемещена или удалена.
            this.genryTableAdapter.Fill(this.kulakovLBDataSet.Genry);



        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TbName.Text = "";
            TbStellazh.Text = "";
            CbAutor.Text = "";
            CbGenry.Text = "";
            CbPublisher.Text = "";
        }
    }
}
