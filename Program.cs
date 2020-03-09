using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise Kennel = new Exercise("Kennel", "React");
            Exercise Tavern = new Exercise("The Tavern", "React");
            Exercise EyesOnTheSky = new Exercise("Eyes on the Sky", "Javascript");
            Exercise Portfolio = new Exercise("Portfolio", "CSS");

            Cohort Cohort100 = new Cohort("Cohort 100");
            Cohort Cohort101 = new Cohort("Cohort 101");
            Cohort Cohort102 = new Cohort("Cohort 102");

            Student JamesB = new Student("James", "Brown", "BigB", Cohort100);
            Cohort100.addStudent(JamesB);
            Student BrockG = new Student("Brock", "Grave", "Grave", Cohort100);
            Cohort100.addStudent(BrockG);
            Student FinleyM = new Student("Finley", "Morm", "Finish", Cohort100);
            Cohort100.addStudent(FinleyM);
            Student TorivV = new Student("Toriv", "Vrock", "TorV", Cohort101);
            Cohort101.addStudent(TorivV);

            Instructor MickFoley = new Instructor("Mick", "Foley", "CactusJack", "Mr Socko", Cohort100);
            Instructor ProfessorX = new Instructor("Charles", "Xavier", "ProfX", "Mind Power", Cohort101);
            Instructor ZombieDust = new Instructor("Zombie ", "Dust ", "ZombieDust ", "infect ", Cohort101);
            Instructor RoberPatterson = new Instructor("Robert ", "Patterson ", "Batman ", "Ninja Skills ", Cohort102);
            Instructor HHH = new Instructor("Hunter ", "Hurst ", "HHH ", "piledriver ", Cohort102);

            ProfessorX.assignExercise(Tavern, JamesB);
            ProfessorX.assignExercise(Portfolio, BrockG);
            ProfessorX.assignExercise(EyesOnTheSky, JamesB);
            ProfessorX.assignExercise(Portfolio, TorivV);
            ProfessorX.assignExercise(EyesOnTheSky, FinleyM);
            ProfessorX.assignExercise(Portfolio, JamesB);
            ProfessorX.assignExercise(Kennel, TorivV);

            foreach (Student student in Cohort100.Students)
            {
                student.Description();
            }

            foreach (Student student in Cohort101.Students)
            {
                student.Description();
            }

        }
    }
}