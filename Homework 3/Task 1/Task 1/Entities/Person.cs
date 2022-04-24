namespace Task_1.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }

        public string PrintPersonInfo()
        {
            return $"{FirstName} - {LastName} - {Age} year/s old - {Occupation} - {Dogs.Count} dog/s";
        }
    }
}
