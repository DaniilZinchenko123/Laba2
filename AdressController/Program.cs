using AdressController;

internal class Program
{
    private static void Main(string[] args)
    {
        Address address = new Address();
        address.Index = "12345";
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.Street = "Main Street";
        address.House = "123";
        address.Apartment = "45";
        Console.WriteLine(address.DisplayAddress());
    }
}