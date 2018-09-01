//OCP


//Bad
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

/********************************************/

public class EmployeeDB
{
    public virtual Employee Select()
    {
        //Old Select Method
    }
}
public class EmployeeManagerDB : EmployeeDB
{
    public override Employee Select()
    {
        //Select method as per Manager
        //UI requirement
    }
}

//Example:

//Normal Screen
EmployeeDB objEmpDb = new EmployeeDB();
Employee objEmp = objEmpDb.Select();

//Manager Screen
EmployeeDB objEmpDb = new EmployeeManagerDB();
Employee objEmp = objEmpDb.Select();



//Extension Method

Public static class MyExtensionMethod{
    public static Employee managerSelect(this EmployeeDB employeeDB) {
        //Select method as per Manager
    }
}

//Manager Screen
Employee objEmp = EmployeeDB.managerSelect();