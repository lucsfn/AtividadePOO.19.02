using Entidades;

namespace Derivados
{
    public class Eletronico : Produto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Voltagem { get; set; }
        public int ConsumoDeEnergia { get; set; }

        public string ValidaMarca(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new System.Exception("Nome inválido.");
            }

            else
            {
                return marca;
            }
        }

        public string ValidaModelo(string modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo))
            {
                throw new System.Exception("Modelo inválido.");
            }

            else
            {
                return modelo;
            }
        }

        public int ValidaVoltagem(int voltagem)
        {
            if (voltagem < 0)
            {
                throw new System.Exception("Voltagem inválida.");
            }

            else
            {
                return voltagem;
            }
        }

        public int ValidaConsumoDeEnergia(int consumoDeEnergia)
        {
            if (consumoDeEnergia < 0)
            {
                throw new System.Exception("Consumo de energia inválido.");
            }

            else
            {
                return consumoDeEnergia;
            }
        }

        public Eletronico(int codigo, string nome, double preco, string descricao, double peso, string marca, string modelo, int voltagem, int consumoDeEnergia) : base(codigo, nome, preco, descricao, peso)
        {
            Marca = ValidaMarca(marca);
            Modelo = ValidaModelo(modelo);
            Voltagem = ValidaVoltagem(voltagem);
            ConsumoDeEnergia = ValidaConsumoDeEnergia(consumoDeEnergia);
        }

        public override string ListaProduto()
        {
            return $"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco}\nDescrição: {Descricao}\nPeso: {Peso}\nMarca: {Marca}\nModelo: {Modelo}\nVoltagem: {Voltagem}\nConsumo de energia: {ConsumoDeEnergia}";
        }

    }
}