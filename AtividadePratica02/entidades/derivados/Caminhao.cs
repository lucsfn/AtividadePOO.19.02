using Entidades;

namespace Derivados
{
    public class Caminhao : Veiculo
    {
        public int CapacidadeCarga { get; set; }
        public int QuantidadeEixos { get; set; }
        public int Comprimento { get; set; }
        public bool PossuiCarroceria { get; set; }

        public int ValidaCapacidadeCarga(int capacidadeCarga)
        {
            if (capacidadeCarga < 0)
            {
                throw new System.Exception("Capacidade de carga inválida.");
            }

            else
            {
                return capacidadeCarga;
            }
        }

        public int ValidaQuantidadeEixos(int quantidadeEixos)
        {
            if (quantidadeEixos < 0)
            {
                throw new System.Exception("Quantidade de eixos inválida.");
            }

            else
            {
                return quantidadeEixos;
            }
        }

        public int ValidaComprimento(int comprimento)
        {
            if (comprimento < 0)
            {
                throw new System.Exception("Comprimento inválido.");
            }

            else
            {
                return comprimento;
            }
        }

        public Caminhao (string modelo, string marca, string placa, double velocidadeMaxima, double peso, double preco, double consumo, int quantidadeDeRodas, int capacidadeCarga, int quantidadeEixos, int comprimento, bool possuiCarroceria) : base (modelo, marca, placa, velocidadeMaxima, peso, preco, consumo, quantidadeDeRodas)
        {
            CapacidadeCarga = ValidaCapacidadeCarga(capacidadeCarga);
            QuantidadeEixos = ValidaQuantidadeEixos(quantidadeEixos);
            Comprimento = ValidaComprimento(comprimento);
            PossuiCarroceria = possuiCarroceria;
        }

    }
}