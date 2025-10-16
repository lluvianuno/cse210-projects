class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lenght, double distance) : base(date, lenght)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / _length;
        return speed * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}