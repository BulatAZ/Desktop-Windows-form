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
                var firstCity = new City { Name = "Казань", Code = 8843, Region = "Татарстан" };
                var secondCity = new City { Name = "Новосибирск", Code = 383, Region = "Новосибирская область" };
                var thirdCity = new City { Name = "Ульяновск", Code = 8422, Region = "Ульяновская область" };
                var fourthCity = new City { Name = "Набережные Челны", Code = 88552, Region = "Татарстан" };
                var fifthCity = new City { Name = "Уфа", Code = 8347, Region = "Башкортостан" };

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
