using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Dal
{
    
    internal class LoginDal
    {
        public bool tem = false;
        public string menssagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {
            // Comando sql para verificar se tem no banco
            cmd.CommandText = "select * from logins whre email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", "login");
            cmd.Parameters.AddWithValue("@senha", "senha");

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.menssagem = "Erro com Banco de Dados";
            }
            
            return tem;
        }

        public string Cadastrar(string login, string senha, string confSenha)
        {
            //Comandos para inserir
            return menssagem;
        }
    }
}
