public class Job
{
    public string _jobTitle;
    public string _company;
    public int _endYear;
    public int _startYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}