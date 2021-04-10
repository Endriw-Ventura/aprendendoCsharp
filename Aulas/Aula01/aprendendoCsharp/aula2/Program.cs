using System;

namespace bytebank
{
    class Program
    {
        static void Main()
        {
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor patricia = new Diretor("1548.664.654-85");
            patricia.Nome = "Patricia";
            patricia.Senha = "123456";
            sistemaInterno.Logar(patricia, "123456");
            sistemaInterno.Logar(patricia, "123");

            GerenteDeConta roberta = new GerenteDeConta("154.658.652-85");
            roberta.Nome = "Roberta";
            roberta.Senha = "12345";
        }
        
    
    }
}
