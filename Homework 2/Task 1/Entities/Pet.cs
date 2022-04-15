using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;

namespace Task_1.Entities
{
    public abstract class Pet<T>
    {
        public string Name { get; set; }

        public PetType Type { get; set; }

        public int Age { get; set; }

        protected Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
