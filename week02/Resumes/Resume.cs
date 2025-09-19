public class Resume
{
    public string _member;
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_member}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}