namespace _28._04_Pratice.Models
{
    public class Product
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public Product()
        {
            _id++;
            Id = _id;
        }
        public Product( string name):this() 
        { 
            Name = name;
        }
    }
}
