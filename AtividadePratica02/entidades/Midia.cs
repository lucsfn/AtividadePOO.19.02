namespace Entidades
{
    public abstract class Midia
    {
        public string Nome { get; set; }
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

        public Midia(string nome, DateTime dataDeLancamento)
        {
            Nome = ValidaNome(nome);
            DataDeLancamento = ValidaDataDeLancamento(dataDeLancamento);
        }

        public virtual string ListaMidia ()
        {
            return $"Nome: {Nome}\nData de lançamento: {DataDeLancamento}";
        }

    }
}