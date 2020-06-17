using System;

namespace Aula15TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Permissao permissao = new Permissao();
            permissao.Autorizar();
            permissao.Acessar(permissao.Permitir);
        }
    }
}