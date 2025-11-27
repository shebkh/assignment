public class Employee
{
    private static int _sequence = 1000; 

    public string No { get; private set; }           
    public string Fullname { get; set; }

    private string _position;
    public string Position
    {
        get => _position;
        set
        {
            if (value.Length < 2)
                throw new Exception("Position minimum 2 letters.");
            _position = value;
        }
    }

    private double _salary;
    public double Salary
    {
        get => _salary;
        set
        {
            if (value < 250)
                throw new Exception("Salary cannot be less than 250.");
            _salary = value;
        }
    }

    public string DepartmentName { get; set; }

    public Employee(string fullname, string position, double salary, string departmentName)
    {
        Fullname = fullname;
        Position = position;
        Salary = salary;
        DepartmentName = departmentName;

       
        No = departmentName.Substring(0, 2).ToUpper() + _sequence;
        _sequence++;
    }
}
