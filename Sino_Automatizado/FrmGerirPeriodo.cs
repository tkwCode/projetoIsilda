using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sino_Automatizado
{
    public partial class FrmGerirPeriodo : Form
    {
        public FrmGerirPeriodo()
        {
            InitializeComponent();
        }

        private void btnAutomatizar_Click(object sender, EventArgs e)
        {
            FrmConrol control = new FrmConrol();
            control.Show();
            this.Hide();
        }
    }
}
