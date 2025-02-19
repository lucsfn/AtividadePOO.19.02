using Entidades;

namespace Derivados
{
    public class Filme : Midia
    {
        public TimeOnly Duracao { get; set; }
        public string Autor { get; set; }
        public string GeneroCinematografico { get; set; }
        public string Sinopse { get; set; }
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

        public string ValidaGeneroCinematografico(string generoCinematografico)
        {
            if (string.IsNullOrWhiteSpace(generoCinematografico))
            {
                throw new System.Exception("Gênero inválido.");
            }

            else
            {
                return generoCinematografico;
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

        public Filme (string nome, DateTime dataDeLancamento, string idioma, TimeOnly duracao, string autor, string generoCinematografico, string sinopse, bool temDublagem) : base (nome, dataDeLancamento, idioma)
        {
            Duracao = duracao;
            Autor = ValidaAutor(autor);
            GeneroCinematografico = ValidaGeneroCinematografico(generoCinematografico);
            Sinopse = ValidaSinopse(sinopse);
            TemDublagem = temDublagem;
        }

        public override string ListaMidia()
        {
            return $"Nome: {Nome}\nData de lançamento: {DataDeLancamento}\nDuração: {Duracao}\nAutor: {Autor}\nGênero cinematográfico: {GeneroCinematografico}\nSinopse: {Sinopse}\nIdioma: {Idioma}\nTem dublagem: {TemDublagem}";
        }

    }
}