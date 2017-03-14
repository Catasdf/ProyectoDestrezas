using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destrezas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login windowLogin = new Login();
            windowLogin.MdiParent = this;
            windowLogin.Show();
            
        }

        public bool openForm()
        {

            return true;
        }
    }
}
