namespace Entidades
{
    public abstract class Midia
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public DateTime DataDeLancamento { get; set; }

        public string ValidaNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new System.Exception("Nome inválido.");
            }

            else
            {
                return nome;
            }
        }

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

        public DateTime ValidaDataDeLancamento(DateTime dataDeLancamento)
        {
            if (dataDeLancamento > DateTime.Now)
            {
                throw new System.Exception("Data de lançamento inválida.");
            }

            else
            {
                return dataDeLancamento;
            }
        }

        public Midia(string nome, string autor, DateTime dataDeLancamento)
        {
            Nome = ValidaNome(nome);
            Autor = ValidaAutor(autor);
            DataDeLancamento = ValidaDataDeLancamento(dataDeLancamento);
        }

        public virtual string ListaMidia ()
        {
            return $"Nome: {Nome}\nAutor: {Autor}\nData de lançamento: {DataDeLancamento}";
        }

    }
}