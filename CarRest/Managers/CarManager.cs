using CarLib.model;

namespace CarRest.Managers
{
    public class CarManager
    {
        private static List<Car> _cars = new List<Car>()
        {
            new Car("AA12345", 23000, "aa"),
            new Car("BB12345", 34000, "bb"),
            new Car("CC12345", 213000, "cc"),
            new Car("DD12345", 123000, "dd")
        };

        public CarManager()
        {
        }

        public List<Car> GetAll()
        {
            return new List<Car>(_cars);
        }

        public Car GetOne(String regNo)
        {
            return _cars.Find(c => c.RegNo == regNo) ?? throw new KeyNotFoundException();
        }

        public Car Add(Car car)
        {
            //CarValidator.CheckRegNo(car.RegNo);
            //CarValidator.CheckName(car.Name);
            //CarValidator.CheckPrice(car.Price);
            CarValidator.CheckCar(car);

            _cars.Add(car);
            return car;
        }

        public Car Delete(String regNo)
        {
            Car c = GetOne(regNo);
            _cars.Remove(c);
            return c;
        }
    }
}
