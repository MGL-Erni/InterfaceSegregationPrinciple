namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("EmployeeBob");
            Manager myManager = new Manager("ManagerBob");
            Admin myAdmin = new Admin("AdminBob");

            myEmployee.TimeIn();
            myEmployee.Work();
            Console.WriteLine();

            myManager.TimeIn();
            myManager.Work();
            myManager.Manage();
            Console.WriteLine();

            myAdmin.TimeIn();
            myAdmin.Work();
            myAdmin.DeleteUser();
        }
    }
}
