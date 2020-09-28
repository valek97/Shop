using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
              return  new List<Car> 
                {
                    new Car 
                    { 
                        name = "Tesla Model S", 
                        shortDesc = "Быстрый Автомобиль", 
                        longDesc = "Красивый, быстрый иочень тихий автомобиль компании Tesla", 
                        img = "/img/1.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        availabel = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/2.jpg",
                        price = 45000,
                        isFavourite = false,
                        availabel = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/3.jpg",
                        price = 65000,
                        isFavourite = true,
                        availabel = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/4.jpg",
                        price = 65000,
                        isFavourite = false,
                        availabel = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/5.jpg",
                        price = 65000,
                        isFavourite = true,
                        availabel = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };

                }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
