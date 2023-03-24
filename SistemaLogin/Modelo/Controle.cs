using SistemaLogin.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public string menssagem = "";
        public bool acessar(string email, string senha)
        {
            LoginDal loginDao = new LoginDal();
            tem = loginDao.verificarLogin(email, senha);
            if(! loginDao.menssagem.Equals(""))
            {
                this.menssagem = loginDao.menssagem;
            }
            return tem;
        }
        public string cadastrar(string email, string senha)
        {
            return menssagem;
        }
    }
}
