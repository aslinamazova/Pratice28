using _28._04_Pratice.Services.Interfaces.RestaurantInterface;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _28._04_Pratice.Services.Implementations.Restaurant
{
    internal class RestaurantService : IRestaurantService
    {
       Models.Restaurant[] restaurants=new Models.Restaurant[0];
        public void Create(string name)
        {
            Array.Resize(ref restaurants, restaurants.Length + 1);
            restaurants[restaurants.Length - 1] = new Models.Restaurant(name);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Restaurant GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}
