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
    public partial class ActiveBook : Form
    {
        public int userId;
        public ActiveBook(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.FullGiveList". При необходимости она может быть перемещена или удалена.
            this.fullGiveListTableAdapter.Fill(this.kulakovLBDataSet.FullGiveList);
            // load params user
        }
    }
}
