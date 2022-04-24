namespace Task_1.Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }

        public string PrintDogInfo()
        {
            return $"{Name} - {Color} - {Race} - {Age} year/s old";
        }
    }
}
