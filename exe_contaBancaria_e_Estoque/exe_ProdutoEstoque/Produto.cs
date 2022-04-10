using System.Globalization;

namespace Estoque
{
    class Produto
    {
        private string _nome; //o método _nome não se aplica a auto propertie pois tem uma tratativa no set
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            this.Quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this.Quantidade = quantidade;
        }

        //Properties nome (get & set)
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
