using Entidades;

namespace Derivados
{
    public class Livro : Midia
    {

        public string Autor { get; set; }
        public string GeneroLiterario { get; set; }
        public string SinopseLiteraria { get; set; }
        public int NumeroDePaginas { get; set; }

        public string ValidaAutor(string autor)
        {
            if (string.IsNullOrWhiteSpace(autor))
            {
                throw new System.Exception("Autor inválido.");
            }

            else
            {
                return autor;
            }
        }

        public string ValidaGeneroLiterario(string generoLiterario)
        {
            if (string.IsNullOrWhiteSpace(generoLiterario))
            {
                throw new System.Exception("Gênero inválido.");
            }

            else
            {
                return generoLiterario;
            }
        }

        public string ValidaSinopseLiteraria(string sinopseLiteraria)
        {
            if (string.IsNullOrWhiteSpace(sinopseLiteraria))
            {
                throw new System.Exception("Sinopse inválida.");
            }

            else
            {
                return sinopseLiteraria;
            }
        }

        public int ValidaNumeroDePaginas(int numeroDePaginas)
        {
            if (numeroDePaginas <= 0)
            {
                throw new System.Exception("Número de páginas inválido.");
            }

            else
            {
                return numeroDePaginas;
            }
        }

        public Livro (string nome, DateTime dataDeLancamento, string idioma, string autor, string generoLiterario, string sinopseLiteraria, int numeroDePaginas) : base (nome, dataDeLancamento, idioma)
        {
            Autor = ValidaAutor(autor);
            GeneroLiterario = ValidaGeneroLiterario(generoLiterario);
            SinopseLiteraria = ValidaSinopseLiteraria(sinopseLiteraria);
            NumeroDePaginas = ValidaNumeroDePaginas(numeroDePaginas);
        }

        public override string ListaMidia()
        {
            return $"Nome: {Nome}\nData de lançamento: {DataDeLancamento}\nIdioma: {Idioma}\nAutor: {Autor}\nGênero literário: {GeneroLiterario}\nSinopse: {SinopseLiteraria}\nNúmero de páginas: {NumeroDePaginas}";
        }

    }
}