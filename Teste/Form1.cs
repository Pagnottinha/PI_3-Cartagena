using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Controls.Add(new TelaJogarInicio());
        }

        private void frmMain_ControlAdded(object sender, ControlEventArgs e)
        {
            this.Size = (sender as Control).Size;
        }
    }
}
