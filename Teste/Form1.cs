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
    public partial class frmEntrarNaPartida : Form
    {
        public frmEntrarNaPartida()
        {
            InitializeComponent();
            Controls.Add(new TelaJogarInicio());
        }
    }
}
