using Entidades;

namespace Derivados
{
    public class Musica : Midia
    {
        public string Autor { get; set; }
        public string GeneroMusical { get; set; }
        public string Letra { get; set; }
        public TimeOnly Duracao { get; set; }

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

        public string ValidaGeneroMusical(string generoMusical)
        {
            if (string.IsNullOrWhiteSpace(generoMusical))
            {
                throw new System.Exception("Gênero inválido.");
            }

            else
            {
                return generoMusical;
            }
        }

        public string ValidaLetra(string letra)
        {
            if (string.IsNullOrWhiteSpace(letra))
            {
                throw new System.Exception("Letra inválida.");
            }

            else
            {
                return letra;
            }
        }

        public Musica (string nome, DateTime dataDeLancamento, string idioma, string autor, string generoMusical, string letra, TimeOnly duracao) : base (nome, dataDeLancamento, idioma)
        {
            Autor = ValidaAutor(autor);
            GeneroMusical = ValidaGeneroMusical(generoMusical);
            Letra = ValidaLetra(letra);
            Duracao = duracao;
        }

        public override string ListaMidia()
        {
            return $"Nome: {Nome}\nData de lançamento: {DataDeLancamento}\nIdioma: {Idioma}\nAutor: {Autor}\nGênero musical: {GeneroMusical}\nLetra: {Letra}\nDuração: {Duracao}";
        }

    }
}