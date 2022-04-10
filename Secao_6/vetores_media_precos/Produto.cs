using System;

namespace vetores_media_precos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
