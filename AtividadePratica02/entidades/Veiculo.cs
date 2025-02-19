namespace Entidades
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public double VelocidadeMaxima { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public double Consumo { get; set; }
        public int QuantidadeDeRodas { get; set ;}

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

        public string ValidaMarca(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new System.Exception("Marca inválida.");
            }

            else
            {
                return marca;
            }
        }

        public string ValidaPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                throw new System.Exception("Placa inválida.");
            }

            else
            {
                return placa;
            }
        }

        public double ValidaVelocidadeMaxima(double velocidadeMaxima)
        {
            if (velocidadeMaxima < 0)
            {
                throw new System.Exception("Velocidade máxima inválida.");
            }

            else
            {
                return velocidadeMaxima;
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

        public double ValidaPreco(double preco)
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

        public double ValidaConsumo(double consumo)
        {
            if (consumo < 0)
            {
                throw new System.Exception("Consumo inválido.");
            }

            else
            {
                return consumo;
            }
        }

        public int ValidaQuantidadeDeRodas(int quantidadeDeRodas)
        {
            if (quantidadeDeRodas < 0)
            {
                throw new System.Exception("Quantidade de rodas inválida.");
            }

            else
            {
                return quantidadeDeRodas;
            }
        }

        public Veiculo (string modelo, string marca, string placa, double velocidadeMaxima, double peso, double preco, double consumo, int quantidadeDeRodas)
        {
            Modelo = ValidaModelo(modelo);
            Marca = ValidaMarca(marca);
            Placa = ValidaPlaca(placa);
            VelocidadeMaxima = ValidaVelocidadeMaxima(velocidadeMaxima);
            Peso = ValidaPeso(peso);
            Preco = ValidaPreco(preco);
            Consumo = ValidaConsumo(consumo);
            QuantidadeDeRodas = ValidaQuantidadeDeRodas(quantidadeDeRodas);
        }

        public virtual string InformacoesVeiculo ()
        {
            return $"Modelo: {Modelo}\nMarca: {Marca}\nPlaca: {Placa}\nVelocidade Máxima: {VelocidadeMaxima}\nPeso: {Peso}\nPreço: {Preco}\nConsumo: {Consumo}\nQuantidade de Rodas: {QuantidadeDeRodas}";
        }

    }
}