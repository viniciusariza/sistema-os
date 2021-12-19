using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        public int ValidarUsuario(string usuario, string senha)
        {
            banco ObjBanco = new banco();
            tb_usuario ObjUser = ObjBanco.tb_usuario.Where(user => user.nome_usuario == usuario && user.senha_usuario == senha && user.situacao_usuario == true).FirstOrDefault();

            if (ObjUser == null)
            {
                return -1;
            }
            else
            {
                return ObjUser.id_usuario;
            }
        }
    }
}
