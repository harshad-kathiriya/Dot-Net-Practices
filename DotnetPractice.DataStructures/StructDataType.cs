using System;

namespace DotnetPractice.DataStructures
{
    class StructDataType
    {
        People _people;

        public StructDataType(People people)
        {
            this._people = people;
        }

        public void Display()
        {
            Console.WriteLine($"Name - {_people.name}");
            Console.WriteLine($"City - {_people.address.city}");
            Console.WriteLine($"State - {_people.address.state}");
        }
    }

    public struct Address
    {
        public string city;
        public string state;
    }

    public struct People
    {
        public string name;
        public Address address;
    }

}