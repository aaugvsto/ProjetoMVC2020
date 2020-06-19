using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCC01.DTO
{
    class tblClienteDTO
    {

        private int id_cliente, tpusuario;
        private string nome_cliente, cpf_cliente, sobrenome_cliente, email_cliente, senha_cliente, nome_mae;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tpusuario { get => tpusuario; set => tpusuario = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }      

        public string Nome_cliente {
            set
            {
                if(value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O Campo Nome é Obrigatório.");

                }
            }
            get { return this.nome_cliente; }
        }

        public string Cpf_cliente {
            set
            {
                if(value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo CPF é obrigatório");
                }
            }
            get { return this.cpf_cliente; }
        }

        public string Nome_mae {
            set
            {
                if(value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo Nome da Mãe é obrigatório");
                }
            }
            get { return this.nome_mae; }        
        }





    }
}
