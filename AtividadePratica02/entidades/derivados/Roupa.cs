using Entidades;

namespace Derivados
{
    public class Roupa : Produto
    {
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Material { get; set; }
        public string Tipo { get; set; }
        public char Genero { get; set; }
        public string Marca { get; set; }

        public string ValidaTamanho(string tamanho)
        {
            if (string.IsNullOrWhiteSpace(tamanho))
            {
                throw new System.Exception("Tamanho inválido.");
            }

            else
            {
                return tamanho;
            }
        }

        public string ValidaCor(string cor)
        {
            if (string.IsNullOrWhiteSpace(cor))
            {
                throw new System.Exception("Cor inválida.");
            }

            else
            {
                return cor;
            }
        }

        public string ValidaMaterial(string material)
        {
            if (string.IsNullOrWhiteSpace(material))
            {
                throw new System.Exception("Material inválido.");
            }

            else
            {
                return material;
            }
        }

        public string ValidaTipo(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                throw new System.Exception("Tipo inválido.");
            }

            else
            {
                return tipo;
            }
        }

        public char ValidaGenero(char genero)
        {
            if (genero != 'M' && genero != 'F' && genero != 'U')
            {
                throw new System.Exception("Gênero inválido.");
            }

            else
            {
                return genero;
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

        public Roupa (int codigo, string nome, double preco, string descricao, double peso, string tamanho, string cor, string material, string tipo, char genero, string marca) : base (codigo, nome, preco, descricao, peso)
        {
            Tamanho = ValidaTamanho(tamanho);
            Cor = ValidaCor(cor);
            Material = ValidaMaterial(material);
            Tipo = ValidaTipo(tipo);
            Genero = ValidaGenero(genero);
            Marca = ValidaMarca(marca);
        }

        public override string ListaProduto()
        {
            return $"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco}\nDescrição: {Descricao}\nPeso: {Peso}\nTamanho: {Tamanho}\nCor: {Cor}\nMaterial: {Material}\nTipo: {Tipo}\nGênero: {Genero}\nMarca: {Marca}";
        }

    }
}