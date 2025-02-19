namespace Entidades
{
    public abstract class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }

        public int ValidaCodigo(int codigo)
        {
            if (codigo < 0)
            {
                throw new System.Exception("Código inválido.");
            }

            else
            {
                return codigo;
            }
        }

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

        public double ValidPreco(double preco)
        {
            if (preco < 0)
            {
                throw new System.Exception("Preço inválido.");
            }

            else
            {
                return preco;
            }
        }

        public string ValidaDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new System.Exception("Descrição inválida.");
            }

            else
            {
                return descricao;
            }
        }

        public double ValidaPeso(double peso)
        {
            if (peso < 0)
            {
                throw new System.Exception("Peso inválido.");
            }

            else
            {
                return peso;
            }
        }

        public Produto(int codigo, string nome, double preco, string descricao, double peso)
        {
            Codigo = ValidaCodigo(codigo);
            Nome = ValidaNome(nome);
            Preco = ValidPreco(preco);
            Descricao = ValidaDescricao(descricao);
            Peso = ValidaPeso(peso);
        }

        public virtual string ListaProduto ()
        {
            return $"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco}\nDescrição: {Descricao}\nPeso: {Peso}";
        }

    }
}