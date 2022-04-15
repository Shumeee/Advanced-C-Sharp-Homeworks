namespace Task_1.Entities
{
    public class Student : User
    {
        public int Points { get; set; }
        public bool HasLoggedIn { get; set; }
        public Student(int id, string firstName, string lastName, string username, string password) : base(id, firstName, lastName, username, password)
        {
            Points = 0;
            HasLoggedIn = false;
        }
        public void Quiz()
        {
            List<string> answers = new List<string>() { "a", "b", "c", "d" };
            Console.WriteLine("Welcome to the quiz!");
            // Question 1
            Console.WriteLine("1. Q: What is the capital of Tasmania?");
            Console.WriteLine("A) Dodoma \nB) Hobart \nC) Launcestron \nD) Wellington"); // B
            CalculateGrade(answers, "b");
            // Question 2
            Console.WriteLine("2. Q: What is the tallest building in the Republic of Congo?");
            Console.WriteLine("A) Kinshasa Democratic Republic of the Congo Temple \nB) Palais de la Nation \nC) Kongo Trade Centre \nD) Nabemba Tower"); // D
            CalculateGrade(answers, "d");
            // Question 3
            Console.WriteLine("3. Q: Which of these is NOT one of Pluto's moons?");
            Console.WriteLine("A) Styx \nB) Hydra \nC) Nix \nD) Lugia"); // C
            CalculateGrade(answers, "c");
            // Question 4
            Console.WriteLine("4. Q: What is the smallest lake in the world?");
            Console.WriteLine("A) Onega Lake \nB) Benxi Lake \nC) Kivu Lake \nD) Wakatipu Lake"); // B
            CalculateGrade(answers, "b");
            // Question 5
            Console.WriteLine("5. Q: What country has the largest population of alpacas?");
            Console.WriteLine("A) Chad \nB) Peru \nC) Australia \nD) Niger"); // B
            CalculateGrade(answers, "b");
            // Other
            Console.WriteLine("Thank you for taking the quiz!");
            Console.WriteLine($"Your final grade is {Points}");
        }
        public int CalculateGrade(List<string> answers, string correctAnswer)
        {
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer.ToLower() == correctAnswer)
                {
                    return Points += 1;
                }
                else if (String.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Please choose an answer!");
                    continue;
                }
                else if (!answers.Contains(answer.ToLower()))
                {
                    Console.WriteLine("Please choose one of the answers!");
                    continue;
                }
                else if (answers.Contains(answer.ToLower())) return Points;
            }
        }
    }
}
