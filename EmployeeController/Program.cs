using EmployeeController;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Employee employee = new Employee("Фурсов", "Андрій");
        string position = "Менеджер";
        int experience = 5;

        double salary = employee.CalculateSalary(position, experience);
        double tax = employee.CalculateTax(salary);

        Console.WriteLine(employee.GetEmployeeInfo(position, experience));
        Console.WriteLine($"Оклад: {salary:C0}");
        Console.WriteLine($"Податковий збір: {tax:C0}");
    }
}