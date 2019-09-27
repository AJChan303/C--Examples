using System;

namespace StudentProject {  
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();
           
            brailee.SetStatus(StudentStatus.Current);
            Console.WriteLine($"Brailee status is {brailee.Status}");
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student maggie = new Student();
            Student glen = new Student();

            Student jesse = new Student("Jesse", "Kyle"); // added firstname lastname from the constructor we made
            jesse.SetStatus(StudentStatus.Past);
            Console.WriteLine($"Jess: {jesse.FirstName} {jesse.LastName}");
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.IsPaid = true;
            alex.Birthdate = new DateTime(1991, 04, 03);
            alex.LastName = "Chan";
            alex.Phone = "5135605531";
            alex.State = "OH";
            alex.City = "Cincinnati";

            Student titus = new Student();
            titus.FirstName = "Titus";
            titus.IsPaid = true;
            titus.Birthdate = new DateTime(2000, 01, 01);
            titus.SetCreditScore(900);
            Console.WriteLine($"Titus' Credit score is {titus.CreditScore}");


            



        }
    }
    enum StudentStatus { Past, Current, Future }
    class Student {
        private static int nextId = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string BootCamp { get; set; }
        public StudentStatus Status { get; set; } //current, future, Past
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }
        public int CreditScore { get; private set; }

        public void  SetCreditScore(int score) {
            if (score >= 400
                && score <= 900) {
                this.CreditScore = score;
            }
            else {
                Console.WriteLine("Credit score must be between 400 and 900");
            }
        }
        public void SetStatus(StudentStatus status) {
             
                this.Status = status;
            
        }
        public Student(string FirstName, string LastName) {
            this.Id = nextId;
            nextId = nextId + 1;
            this.FirstName = FirstName;//this - points to this instance you are creating
            this.LastName = LastName;
        }
        public Student(){// Default constructor
            this.Id = nextId;
            nextId = nextId + 1;
        }
    }
}
