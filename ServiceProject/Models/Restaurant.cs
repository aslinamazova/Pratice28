namespace _28._04_Pratice.Models
{
    public class Restaurant
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public Product[] Products { get; set; } = { };
        public Restaurant()
        {
            _id++;
            Id=_id;
        }
        public Restaurant(string name):this()
        {
            Name = name;
        }
    }
}
