using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulakov.Forms
{
    public partial class ListReaders : Form
    {
        public ListReaders()
        {
            InitializeComponent();
        }

        private void ListReaders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Formular". При необходимости она может быть перемещена или удалена.
            this.formularTableAdapter.Fill(this.kulakovLBDataSet.Formular);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.Rows[e.RowIndex].Index;
            int columIndex = dataGridView1.Columns[e.RowIndex].Index;
            string asc = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Оформить на данного читателя книгу ?", "Номер формуляра = "+asc, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Givebook fGiveBook = new Givebook(asc);
                fGiveBook.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (RbFIO.Checked == true)
            {
                formularBindingSource.Filter = "FIO Like '%" + textBox1.Text + "%'";
            }
            else if (RbGroup.Checked == true)
            {
                formularBindingSource.Filter = "StudentGroup Like '%" + textBox1.Text + "%'";
            }
            else if (RbPhone.Checked == true)
            {
                formularBindingSource.Filter = "Phone Like '%" + textBox1.Text + "%'";
            }
            else if (RbYear.Checked == true)
            {
                formularBindingSource.Filter = "Year Like '%" + textBox1.Text + "%'";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Сохранить измененные данные ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(result == DialogResult.Yes)
            //    formularTableAdapter.Update(booksDataSet.Formular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularBindingSource.Filter = "";
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения в таблице данных ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                formularTableAdapter.Update(this.kulakovLBDataSet.Formular);
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Обновить таблицу данных ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.formularTableAdapter.Fill(this.kulakovLBDataSet.Formular);
        }
    }
}
