namespace Entidades
{
    public abstract class Midia
    {
        public string Nome { get; set; }
        public DateTime DataDeLancamento { get; set; }

        public string Idioma { get; set; }

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

        public string ValdiaIdioma (string idioma)
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

        public Midia(string nome, DateTime dataDeLancamento, string idioma)
        {
            Nome = ValidaNome(nome);
            DataDeLancamento = ValidaDataDeLancamento(dataDeLancamento);
            Idioma = ValdiaIdioma(idioma);
        }

        public virtual string ListaMidia ()
        {
            return $"Nome: {Nome}\nData de lançamento: {DataDeLancamento}\nIdioma: {Idioma}";
        }

    }
}