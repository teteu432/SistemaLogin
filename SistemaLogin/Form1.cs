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
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Entar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();

        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new Login());
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(AbrirCadastro);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();

        }
        private void AbrirCadastro(object obj)
        {
            Application.Run(new Tcadastro());
        }
    }
}
