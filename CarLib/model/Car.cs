using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarLib.Annotations;

namespace CarLib.model
{
    public class Car
    {
        private string _regNo;
        private double _price;
        private string _name;

        public Car():this("dummy", 0, "empty")
        {
        }

        public Car(CarDTO dto)
        {
            RegNo = dto.RegNo;
            Price = dto.Price;
            Name = dto.Name;
        }

        public Car(string regNo, double price, string name)
        {
            RegNo = regNo;
            Price = price;
            Name = name;
        }

        [Required]
        [StringLength(8,MinimumLength = 1, ErrorMessage = "Not a registration Number")]
        public string RegNo
        {
            get => _regNo;
            set
            {
                //PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(value));

                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
                if (value.Length < 1 || 8 < value.Length) throw new ArgumentException("Not a registration Number");
                _regNo = value;
            }
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public event PropertyChangingEventHandler? PropertyChanging;

        
    }
}
