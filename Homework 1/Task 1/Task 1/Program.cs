using Task_1.Entities;
using Task_1.Helpers;
using Task_1.Utilities;
// Classes
List<Student> students = new List<Student>() {
    new Student(1, "David", "Shumanski", "david.shumanski", "password1"),
    new Student(2, "Petko", "Petkovski", "petko.petkovski", "password2"),
    new Student(3, "Mitre", "Mitrovski", "mitre.mitrovski", "password3")
};
List<Teacher> teachers = new List<Teacher>() {
    new Teacher(1, "Albert", "Einstein","albert.einstein", "password1"),
    new Teacher(2, "Stephen", "Hawking","stephen.hawking", "password2"),
    new Teacher(3, "Nikola", "Tesla", "nikola.tesla", "password3"),
};
// Variables
bool flag = false; // Used to check if a user is found when logging in
int count = 1; // Used to count if there are 3 failed attempts at login
string login, username = "", password = "";
// Code
while (true)
{
    Console.WriteLine("Would you like to login as (T)eacher or (S)tudent ? (Press 'X' to exit)");
    login = Console.ReadLine();
    while (true)
    {
        if (login.ToLower().CheckInput())
        {
            Console.WriteLine("Invalid input! Input must contain atleast one character!");
            break;
        }

        else if (login.ToLower() == "t")
        {
            Console.WriteLine("Currently logged in as Teacher");
            username = username.CheckCredentals(LoginInformation.USERNAME);
            password = password.CheckCredentals(LoginInformation.PASSWORD);
            // Checks the database for the teacher
            foreach (Teacher teacher in teachers)
            {
                if (count == 3)
                {
                    Console.WriteLine("Too many failed attempts! Exiting program...");
                    return;
                }
                else if (teacher.Username == username && teacher.Password != password)
                {
                    count++;
                    break;
                }
                else if (teacher.Username == username && teacher.Password == password)
                {
                    teacher.ShowGrades(students);
                    flag = true;
                    count = 1;
                    Console.WriteLine("Press 'ENTER' to exit");
                    if (Console.ReadLine() == "")
                    {
                        Console.WriteLine("Loging out...");
                        break;
                    }
                }
            }
            if (!flag) Console.WriteLine("No users found!");
            if (flag) break;
            continue;
        }
        else if (login.ToLower() == "s")
        {
            Console.WriteLine("Currently logged in as Student");
            username = username.CheckCredentals(LoginInformation.USERNAME);
            password = password.CheckCredentals(LoginInformation.PASSWORD);
            // Checks the database for the student
            foreach (Student student in students)
            {
                if (count == 3)
                {
                    Console.WriteLine("Too many failed attempts! Exiting program...");
                    return;
                }
                else if (student.Username == username && student.Password != password)
                {
                    count++;
                    break;
                }
                else if (student.Username == username && student.Password == password)
                {
                    if (student.HasLoggedIn)
                    {
                        Console.WriteLine("User has already taken the quiz!");
                        break;
                    }
                    student.HasLoggedIn = true;
                    student.Quiz();
                    flag = true;
                    count = 1;
                    Console.WriteLine("Loging out...");
                    break;
                }
            }
            if (!flag) Console.WriteLine("No users found!");
            if (flag) break;
            continue;
        }
        else if (login.ToLower() == "x")
        {
            Console.WriteLine("Exiting program...");
            return;
        }
        else
        {
            Console.WriteLine("Invalid input! Input must be T, S or X!");
            break;
        }
    }
}