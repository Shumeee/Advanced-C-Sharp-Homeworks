using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;

namespace Task_1.Entities
{
    public class Fish : Pet<Fish>
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish(string name, PetType type, int age, string color, int size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information about {Name}: \nType : {Type} \nAge : {Age} \nColor : {Color} \nSize : {Size}cm\n");
        }
    }
}
