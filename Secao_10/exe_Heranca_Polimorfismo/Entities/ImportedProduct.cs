namespace produtos.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price += CustomsFee;
        }

        public override string priceTag()
        {
            return $"{Name} $ {totalPrice().ToString("F2")} (Customs fee: $ {CustomsFee.ToString("F2")})";
        }
    }
}