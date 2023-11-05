using System.Text;
using UserController;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        User user = new User("Android", "Фурсов", "Андрій", 30);
        string userInfo = user.GetUserInfo();
        Console.WriteLine(userInfo);
    }
}