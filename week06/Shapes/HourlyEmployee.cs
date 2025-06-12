public class HourlySalary : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payrate)
    {
        _payRate = payrate;
    }

    public int GetHoursWorked()
    {
        return _hoursWorked;
    }

    public void SetHoursWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    public override float GetPay()
    {
        return _payRate * _hoursWorked;
    }
}