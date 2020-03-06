namespace StudentExcercises
{
  class Instructor
  {
    private string _firstName;
    private string _lastName;

    private string _slackHandle;

    private string _cohort;

    private string _specialty;

    public Instructor(string firstName, string lastName, string cohort, string specialty)
    {
      _firstName = firstName;
      _lastName = lastName;
      _cohort = cohort;
      _specialty = specialty;
    }

  }
}