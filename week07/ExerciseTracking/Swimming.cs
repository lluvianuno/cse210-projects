class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(DateTime date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double operation = _numberOfLaps * 50;
        return operation / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}