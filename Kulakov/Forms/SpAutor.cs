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
    public partial class SpAutor : Form
    {
        public SpAutor()
        {
            InitializeComponent();
        }

        private void SpAutor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kulakovLBDataSet.Autor". При необходимости она может быть перемещена или удалена.
            this.autorTableAdapter.Fill(this.kulakovLBDataSet.Autor);

        }
    }
}
