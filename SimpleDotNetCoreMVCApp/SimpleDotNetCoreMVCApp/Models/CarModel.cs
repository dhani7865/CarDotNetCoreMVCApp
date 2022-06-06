using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotNetCoreMVCApp.Models
{
    public class CarModelListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
    }

    public class CarsModel
    {
       private List<CarModelListItem> carList = null;

        public CarsModel()
        {
            carList = new List<CarModelListItem>() {
                new CarModelListItem() {
                    Id = 1,
                    Name = "BMW",
                    ModelName = "BMW S1",
                    Price = 125000
                },
               new CarModelListItem() {
                    Id = 2,
                    Name = "Mercedes",
                    ModelName = "AMG Sport",
                    Price = 20000
                }
            };
        }

        public List<CarModelListItem> SelectCarList
        {
            get {
                return carList;
            }

            set
            {
                carList = value;
            }
        }
    }
}
