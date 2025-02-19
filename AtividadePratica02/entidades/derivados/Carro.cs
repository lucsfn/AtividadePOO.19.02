using Entidades;

namespace Derivados
{
    public class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }
        public string TipoDeCombustivel { get; set; }
        public char TipoDeCambio { get; set; }
        public bool PossuiArCondicionado { get; set; }

        public int ValidaQuantidadeDePortas(int quantidadeDePortas)
        {
            if (quantidadeDePortas < 0)
            {
                throw new System.Exception("Quantidade de portas inválida.");
            }

            else
            {
                return quantidadeDePortas;
            }
        }

        public string ValidaTipoDeCombustivel(string tipoDeCombustivel)
        {
            if (string.IsNullOrWhiteSpace(tipoDeCombustivel))
            {
                throw new System.Exception("Tipo de combustível inválido.");
            }

            else
            {
                return tipoDeCombustivel;
            }
        }

        public char ValidaTipoDeCambio(char tipoDeCambio)
        {
            if (tipoDeCambio == 'A' || tipoDeCambio == 'M')
            {
                return tipoDeCambio;
            }

            else
            {
                throw new System.Exception("Tipo de câmbio inválido.");
            }
        }
    
        public Carro (string modelo, string marca, string placa, double velocidadeMaxima, double peso, double preco, double consumo, int quantidadeDeRodas, int quantidadeDePortas, string tipoDeCombustivel, char tipoDeCambio, bool possuiArcondicionado) : base (modelo, marca, placa, velocidadeMaxima, peso, preco, consumo, quantidadeDeRodas)
        {
            QuantidadeDePortas = ValidaQuantidadeDePortas(quantidadeDePortas);
            TipoDeCombustivel = ValidaTipoDeCombustivel(tipoDeCombustivel);
            TipoDeCambio = ValidaTipoDeCambio(tipoDeCambio);
            PossuiArCondicionado = possuiArcondicionado;
        }
    
    }
}