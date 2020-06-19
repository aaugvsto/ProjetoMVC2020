using ProjetoMVCC01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCC01.BLL
{
    class tblClienteBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public Boolean Autenticar(string cpf, string nomecliente, string nomemae)
        {
            string consulta = string.Format($@"select * from tbl_clientec01 where cpf_cliente = '{cpf}' and nome_cliente = '{nomecliente}' and nome_mae = '{nomemae}' ;");
            DataTable dt = DaoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}