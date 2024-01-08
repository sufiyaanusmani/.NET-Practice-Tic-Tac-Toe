using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldStyle
{
    internal class Car
    {
        private string _name;
        private int _hp;

        // Constructor
        public Car()
        {
            this._name = "Car";
            this._hp = 0;
        }

        public Car(string name, int hp = 0)
        {
            this._name = name;
            Console.WriteLine($"{this._name} was created");
            this._hp = hp;
        }

        public void SetName(string name)
        {
            if(name == "")
            {
                this._name = "Car";
            }
            else
            {
                this._name = name;
            }
        }

        public string GetName()
        {
            return $"{this._name} car";
        }

        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }
    }
}
