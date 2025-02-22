using Entidades;
using Derivados;

namespace main
{
    public class Program
    {
        public static void Main ()
        {
            Livro livroTeste = new Livro("Teste", DateTime.Now, "Português", "Eu Mesmo", "Gênero", "Sinopse", 345);
            Console.WriteLine(livroTeste.ListaMidia());
            Console.ReadKey();
        }
    }
}