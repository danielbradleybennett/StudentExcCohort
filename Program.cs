using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student JamesB = new Student("James", "Brown", "BigB", 100);
            Student BrockG = new Student("Brock", "Grave", "Grave", 100);
            Student FinleyM = new Student("Finley", "Morm", "Finish", 100);
            Student TorivV = new Student("Toriv", "Vrock", "TorV", 100);

            Cohort One = new Cohort(100);
            Cohort Two = new Cohort(101);
            Cohort Three = new Cohort(102);

        }
    }
}