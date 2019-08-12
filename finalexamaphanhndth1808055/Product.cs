namespace finalexamaphanhndth1808055
{
    public class Product
    {
        public string id;
        public string name;
        public decimal price;

        public Product(string id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Product()
        {
        }
    }
}