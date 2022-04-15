using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;

namespace Task_1.Entities
{
    public class Dog : Pet<Dog>
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, PetType type, int age, bool goodBoi, string favoriteFood) : base(name, type, age)
        {
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information about {Name}: \nType : {Type} \nAge : {Age} \nGood Boy : {GoodBoi} \nFavorite Food : {FavoriteFood}\n");
        }
    }
}
