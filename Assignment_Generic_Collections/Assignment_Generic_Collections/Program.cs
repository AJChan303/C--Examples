using System;

namespace Assignment_Generic_Collections {
    class Program {
        static void Main(string[] args) {
            var students = new System.Collections.Generic.List<Student> {
    new Student { Name = "Abby",    GPA = 4.22M },
    new Student { Name = "Bobby",   GPA = 2.98M },
    new Student { Name = "Cory",    GPA = 2.80M },
    new Student { Name = "Davey",   GPA = 4.42M },
    new Student { Name = "Eddy",    GPA = 4.15M },
    new Student { Name = "Fanny",   GPA = 3.73M },
    new Student { Name = "Georgie", GPA = 1.24M },
    new Student { Name = "Harry",   GPA = 3.59M },
    new Student { Name = "Izzy",    GPA = 2.38M },
    new Student { Name = "Jimmy",   GPA = 4.93M }
};
            decimal highest = 0M;
            Student histudent = null;

            foreach (var item in students) {
                if (item.GPA > highest)
                    highest = item.GPA;
                histudent = item;               
            }
              Console.WriteLine($"Highest GPA Student is {histudent.Name} with a GPA of {histudent.GPA}");
        }
      
        }
    }
    

