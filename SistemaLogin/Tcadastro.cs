using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SistemaLogin
{
    public partial class Tcadastro : Form
    {
        Thread t3;
        public Tcadastro()
        {
            InitializeComponent();
        }

        private void VoltarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(AbrirJanela);
            t3.SetApartmentState(ApartmentState.MTA);
            t3.Start();
        }
        private void AbrirJanela(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
