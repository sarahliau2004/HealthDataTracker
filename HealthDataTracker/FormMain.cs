using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDataTracker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form dlgAdd = new FormAdd();
            dlgAdd.ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form dlgView = new FormView();
            dlgView.ShowDialog();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            Form dlgCompare = new FormCompare();
            dlgCompare.ShowDialog();
        }
    }
}
