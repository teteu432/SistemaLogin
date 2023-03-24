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
using SistemaLogin.Modelo;

namespace SistemaLogin
{
    
    public partial class Login : Form
    {
        Thread t1;
        Thread t2;
       
        public Login()
        {
            InitializeComponent();
        }

        private void VoltarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void AbrirJanela(object obj)
        {
            Application.Run(new Form1());
        }

        private void TelaCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(JanelaCadastro);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }
        private void JanelaCadastro(object obj)
        {
            Application.Run(new Tcadastro());
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(Usuario.Text, Senha.Text);
            if (controle.menssagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Principal tp = new Principal();
                    tp.Show();

                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.menssagem);
            }
        

        }
    }
}
