using Entidades;

namespace Derivados
{
    public class Alimento : Produto
    {
        public DateTime DataValidade { get; set; }
        public string Origem { get; set; }
        public bool PrecisaDeRefrigeracao { get; set; }

        public DateTime ValidaDataValidade(DateTime dataValidade)
        {
            if (dataValidade < DateTime.Now)
            {
                throw new System.Exception("Data de validade inválida.");
            }

            else
            {
                return dataValidade;
            }
        }

        public string ValidaOrigem(string origem)
        {
            if (string.IsNullOrWhiteSpace(origem))
            {
                throw new System.Exception("Origem inválida.");
            }

            else
            {
                return origem;
            }
        }

        public bool ValidaPrecisaRefrigeracao(bool precisaDeRefrigeracao)
        {
            if (precisaDeRefrigeracao == true)
            {
                return precisaDeRefrigeracao;
            }

            else if (precisaDeRefrigeracao == false)
            {
                return precisaDeRefrigeracao;
            }

            else
            {
                throw new System.Exception("Precisa de refrigeração inválido.");
            }
        }

        public Alimento (int codigo, string nome, double preco, string descricao, double peso, DateTime dataValidade, string origem, bool precisaDeRefrigeracao) : base (codigo, nome, preco, descricao, peso)
        {
            DataValidade = dataValidade;
            Origem = origem;
            PrecisaDeRefrigeracao = precisaDeRefrigeracao;
        }

        public override string ListaProduto()
        {
            return $"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco}\nDescrição: {Descricao}\nPeso: {Peso}\nData de validade: {DataValidade}\nOrigem: {Origem}\nPrecisa de refrigeração: {PrecisaDeRefrigeracao}";
        }

    }
}