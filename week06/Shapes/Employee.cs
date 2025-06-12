public abstract class Employee
{
    public string _name = "";
    private string _ID = "";

    public Employee()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetID()
    {
        return _ID;
    }

    public void SetID(string ID)
    {
        _ID = ID;
    }

    public abstract float GetPay();
}