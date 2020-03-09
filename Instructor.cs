using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string Specialty { get; set; }

    public Cohort Cohort { get; set; }

    public Instructor(string firstName, string lastName, string slackHandle, string specialty, Cohort cohort)
    {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      Specialty = specialty;
      Cohort = cohort;
    }
    public void assignExercise(Exercise exercise, Student student)
    {
      student.Exercises.Add(exercise);
    }

  }
}