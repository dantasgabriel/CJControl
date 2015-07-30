using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CJControl
{
    public partial class frmCadastrarComponente : Form
    {
        frmPrincipal Principal;

        public frmCadastrarComponente()
        {
            InitializeComponent();
        }

        public frmCadastrarComponente(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            Principal = formularioPrincipal;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
