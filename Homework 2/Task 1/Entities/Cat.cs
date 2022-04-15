using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;

namespace Task_1.Entities
{
    public class Cat : Pet<Cat>
    {
        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }
        public Cat(string name, PetType type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information about {Name}: \nType : {Type} \nAge : {Age} \nLazy : {Lazy} \nLivesLeft : {LivesLeft}\n");
        }
    }
}
