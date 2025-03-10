using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
        _company = "Company";
        _jobTitle = "Job Title";
        _startYear = 0;
        _endYear = 0;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
