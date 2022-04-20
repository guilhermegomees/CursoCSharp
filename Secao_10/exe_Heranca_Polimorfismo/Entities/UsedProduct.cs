namespace produtos.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2")} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
