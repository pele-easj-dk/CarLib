﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.model
{
    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Address={Address}";
        }




        public static void ValidateId(int id)
        {
            if (id <= 0) throw new ArgumentException("Id must be a positive number");

        }

        public static void ValidateName(String name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Name must not be null nor empty");

            if (name.Length < 3) throw new ArgumentException("name must be at least 3 character long");

        }
        public static void ValidateAddress(String address)
        {
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentNullException("Address must not be null nor empty");

            if (address.Length < 10) throw new ArgumentException("Address must be at least 10 character long");

        }

        public virtual void Validate()
        {
            ValidateId(Id);
            ValidateName(Name);
            ValidateAddress(Address);
        }

    }
}
