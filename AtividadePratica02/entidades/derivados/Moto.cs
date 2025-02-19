using Entidades;

namespace Derivados
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public bool PossuiPartidaEletrica { get; set; }
        public string TipoDeMoto { get; set; }
        public int QuantidadeDeMarchas { get; set; }

        public int ValidaCilindradas(int cilindradas)
        {
            if (cilindradas < 0)
            {
                throw new System.Exception("Cilindradas inválidas.");
            }

            else
            {
                return cilindradas;
            }
        }

        public bool ValidaPossuiPartidaEletrica(bool possuiPartidaEletrica)
        {
            if (possuiPartidaEletrica == true)
            {
                return possuiPartidaEletrica;
            }

            else if (possuiPartidaEletrica == false)
            {
                return possuiPartidaEletrica;
            }

            else
            {
                throw new System.Exception("Valor inválido.");
            }
        }

        public string ValidaTipoDeMoto(string tipoDeMoto)
        {
            if (string.IsNullOrWhiteSpace(tipoDeMoto))
            {
                throw new System.Exception("Tipo de moto inválido.");
            }

            else
            {
                return tipoDeMoto;
            }
        }

        public int ValidaQuantidadeDeMarchas(int quantidadeDeMarchas)
        {
            if (quantidadeDeMarchas < 0)
            {
                throw new System.Exception("Quantidade de marchas inválida.");
            }

            else
            {
                return quantidadeDeMarchas;
            }
        }

        public Moto (string modelo, string marca, string placa, double velocidadeMaxima, double peso, double preco, double consumo, int quantidadeDeRodas, int cilindradas, bool possuiPartidaEletrica, string tipoDeMoto, int quantidadeDeMarchas) : base (modelo, marca, placa, velocidadeMaxima, peso, preco, consumo, quantidadeDeRodas)
        {
            Cilindradas = ValidaCilindradas(cilindradas);
            PossuiPartidaEletrica = ValidaPossuiPartidaEletrica(possuiPartidaEletrica);
            TipoDeMoto = ValidaTipoDeMoto(tipoDeMoto);
            QuantidadeDeMarchas = ValidaQuantidadeDeMarchas(quantidadeDeMarchas);
        }

        public override string InformacoesVeiculo()
        {
            return $"Modelo: {Modelo}\nMarca: {Marca}\nPlaca: {Placa}\nVelocidade máxima: {VelocidadeMaxima} km/h\nPeso: {Peso} kg\nPreço: R$ {Preco}\nConsumo: {Consumo} km/l\nQuantidade de rodas: {QuantidadeDeRodas}\nCilindradas: {Cilindradas}\nPossui partida elétrica: {PossuiPartidaEletrica}\nTipo de moto: {TipoDeMoto}\nQuantidade de marchas: {QuantidadeDeMarchas}";
        }

    }
}