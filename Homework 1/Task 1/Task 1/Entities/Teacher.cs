namespace Task_1.Entities
{
    public class Teacher : User
    {
        public Teacher(int id, string firstName, string lastName, string username, string password) : base(id, firstName, lastName, username, password)
        {
        }

        public void ShowGrades(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.HasLoggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.FirstName} {student.LastName} - Grade: {student.Points}");
                }
            }
            foreach (Student student in students)
            {
                if (!student.HasLoggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.FirstName} {student.LastName} has NOT taken the quiz!");
                }
            }
            Console.ResetColor();
        }
    }
}
