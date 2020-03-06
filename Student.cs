using System;
using System.Collections.Generic;

namespace StudentExcercises
{
  class Student
  {

    private string _firstName;
    private string _lastName;

    private string _slackHandle;

    private int _cohort;

    public List<Excercise> Excercises = new List<Excercise>();
    public void addExcercise(Excercise excercise)
    {
      Excercises.Add(excercise);
    }

    public Student(string firstName, string lastName, int cohort, string slackHandle)
    {
      _firstName = firstName;
      _lastName = lastName;
      _cohort = cohort;
      _slackHandle = slackHandle;

    }

  }
}