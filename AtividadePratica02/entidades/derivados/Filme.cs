using Entidades;

namespace Derivados
{
    public class Filme : Midia
    {
        public TimeOnly Duracao { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public string Idioma { get; set; }
        public bool TemDublagem { get; set; }

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

        public string ValidaGenero(string genero)
        {
            if (string.IsNullOrWhiteSpace(genero))
            {
                throw new System.Exception("Gênero inválido.");
            }

            else
            {
                return genero;
            }
        }

        public string ValidaSinopse(string sinopse)
        {
            if (string.IsNullOrWhiteSpace(sinopse))
            {
                throw new System.Exception("Sinopse inválida.");
            }

            else
            {
                return sinopse;
            }
        }

        public string ValidaIdioma(string idioma)
        {
            if (string.IsNullOrWhiteSpace(idioma))
            {
                throw new System.Exception("Idioma inválido.");
            }

            else
            {
                return idioma;
            }
        }

        public Filme (string nome, DateTime dataDeLancamento, TimeOnly duracao, string autor, string genero, string sinopse, string idioma, bool temDublagem) : base (nome, dataDeLancamento)
        {
            Duracao = duracao;
            Autor = ValidaAutor(autor);
            Genero = ValidaGenero(genero);
            Sinopse = ValidaSinopse(sinopse);
            Idioma = ValidaIdioma(idioma);
            TemDublagem = temDublagem;
        }





















    }
}