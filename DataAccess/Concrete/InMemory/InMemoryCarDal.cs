using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {

            new Car {CarId=1,BrandId=1,ColorId=2,DailyPrice=1550,ModelYear=2021,Description="BMW" },
            new Car {CarId=2,BrandId=2,ColorId=3,DailyPrice=1350,ModelYear=2021,Description="Audi" },
            new Car {CarId=3,BrandId=3,ColorId=2,DailyPrice=500,ModelYear=2021,Description="Peugeout" },
            new Car {CarId=4,BrandId=4,ColorId=2,DailyPrice=350,ModelYear=2021,Description="Hyundai" },
            new Car {CarId=5,BrandId=5,ColorId=2,DailyPrice=1800,ModelYear=2021,Description="Mercedess" }


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carOfDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carOfDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carOfUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carOfUpdate.BrandId = car.BrandId;
            carOfUpdate.ColorId = car.ColorId;
            carOfUpdate.DailyPrice = car.DailyPrice;
            carOfUpdate.Description = car.Description;
            carOfUpdate.ModelYear = car.ModelYear;
        }
    }
}
