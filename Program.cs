using System;

namespace Lightening
{

    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();

            Instructor steve = new Instructor("Steve", "Brownlee");
            Instructor bob = new Instructor("Bob", "Smith");

            Student jewel = new Student("Jewel", "Ramirex");
            Student jack = new Student("Jack", "Miller");

            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(jewel);
            cohort26.InstructorList.Add(bob);
            cohort26.StudentList.Add(jack);

            Exercise ex1 = new Exercise();
            ex1.Name = "ChickenMonkey";
            ex1.Language = "JavaScript";
            ex1.GitHubUrl = "www.github.com";

            Exercise ex2 = new Exercise();
            ex2.Name = "Planets";
            ex2.Language = "C#";
            ex2.GitHubUrl = "www.github.com";

//Instructor is assigning an exercise to a student
            steve.AssignExercise(jewel, ex1);
            steve.AssignExercise(jewel, ex2);

//Pick one of the students and write to the Console each exercise that has been assigned to that student
            foreach (Exercise item in jewel.AssignedExercises)
            {
            Console.WriteLine($"{jewel.Name}: {item.Name}");
                
            }
        }
    }
}
