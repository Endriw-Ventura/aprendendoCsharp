using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class SistemaInterno
    {
        public bool Logar (IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema interno!");
                return true;
            } else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
