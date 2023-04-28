using _28._04_Pratice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04_Pratice.Services.Interfaces.RestaurantInterface
{
    public interface IRestaurantService
    {
        public void Create(string name);
        public void Delete(string name);
        public void Update(string name);
        public Restaurant GetById(string id);

    }
}
