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
    public partial class FrmInitConfig : Form
    {
        public FrmInitConfig()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            FrmGerirPeriodo peridos = new FrmGerirPeriodo();
            peridos.Show();
            this.Hide();
        }
    }
}
