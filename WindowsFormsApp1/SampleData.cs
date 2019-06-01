using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SampleData
    {
        public static void EditCity(CitiesDBContext dbContext)
        {
            if (!dbContext.Cities.Any())
            {
                var firstCity = new City { Name = "Казань" };
                var secondCity = new City { Name = "Новосибирск" };
                var thirdCity = new City { Name = "Ульяновск" };
                var fourthCity = new City { Name = "Набережные Челны" };
                var fifthCity = new City { Name = "Уфа" };

                dbContext.Cities.Add(firstCity);
                dbContext.Cities.Add(secondCity);
                dbContext.Cities.Add(thirdCity);
                dbContext.Cities.Add(fourthCity);
                dbContext.Cities.Add(fifthCity);

                dbContext.SaveChanges();
            }            
        }
    }
}
