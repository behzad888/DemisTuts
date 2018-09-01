//SRP


//Bad
public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeNo { get; set; }

    public void Insert(Employee e)
    {
        //Database Logic written here
    }
    public void GenerateReport(Employee e)
    {
        //Set report formatting
    }
}

/***********************************************/

public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeNo { get; set; }
}

public class EmployeeDB
{
    public void Insert(Employee e)
    {
        //Database Logic written here
    }
    public Employee Select()
    {
        //Database Logic written here
    }
}

public class EmployeeReport
{
    public void GenerateReport(Employee e)
    {
        //Set report formatting
    }
}