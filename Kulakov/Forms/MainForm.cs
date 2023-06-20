using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulakov.Forms
{
    public partial class MainForm : Form
    {
        
        int employeeId;
        int employeeRole;
        public MainForm(int i, int r)
        {
            employeeId = i;
            employeeRole = r;
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fAb = new About();
            fAb.Show();

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть выйти из программы?", "выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        
        private void выйтиИзУчетнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из учетной записи ?", "выход из учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }


        private void регистрацияФормуляраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaders fread = new AddReaders();
            fread.MdiParent = this;
            fread.Show();
        }

        private void открытьПолныйСписокФормуляровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListReaders fread = new ListReaders();
            fread.MdiParent = this;
            fread.Show();
        }

        private void зарегистрироватьНовуюКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook fbook = new AddBook();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void просмотрДоступныхЭкземпляровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAccess fbook = new BookAccess();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void просмотрВсехЭкземпляровToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            BookList fbook = new BookList();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void новыйПрокатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Givebook givebook = new Givebook();
            givebook.MdiParent = this;
            givebook.Show();
        }

        private void просмотрВсехЭкземпляровToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void возвратКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook fbook = new ReturnBook();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void продлитьВыдачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extendbook fext = new Extendbook();
            fext.MdiParent = this;
            fext.Show();
        }

        private void авторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SpAutor fautor = new SpAutor();
            fautor.Show();
        }

        private void жанрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SpGenry fgenry = new SpGenry();
            fgenry.Show();
        }

        private void издательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpPublisher fpubl = new SpPublisher();
            fpubl.Show();

        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveBook info = new ActiveBook(employeeId);
            info.Show();
        }

        private void просмотрКнигВВыдачиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьСписокАктивныхПрокатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveBook book = new ActiveBook(employeeId);
            book.MdiParent = this;
            book.Show();
        }

        private void поПоступлениюКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            othet fot = new othet();
            fot.MdiParent = this;
            fot.Show();
        }
    }
}
