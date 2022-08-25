using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.model
{
    public static class CarValidator
    {
        public static void CheckRegNo(String regNo)
        {
            if (String.IsNullOrWhiteSpace(regNo))
            {
                throw new ArgumentNullException("Car registration number must not be empty nor null");
            }   
            
            if (regNo.Length < 1 || 8 < regNo.Length)
            {
                throw new ArgumentException("Car registration Number must be between 1 to 8 characters");
            }
        }

        public static void CheckName(String name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Car name must not be empty nor null");
            }

            if (name.Length < 3)
            {
                throw new ArgumentException("Car name must be between at least 3 characters");
            }
        }

        public static void CheckPrice(double? price)
        {
            if (price is null)
            {
                throw new ArgumentNullException("Car price must not be null");
            }

            if (price < 1)
            {
                throw new ArgumentException("Car price must be above zero");
            }
        }

        public static void CheckCar(Car car)
        {
            CheckRegNo(car.RegNo);
            CheckName(car.Name);
            CheckPrice(car.Price);
        }

    }
}
