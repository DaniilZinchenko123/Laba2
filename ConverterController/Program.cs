using ConverterController;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Converterr converter = new Converterr(38.0, 40.0, 9.0);        

         double uahAmount = 1000.0;
        double usdAmount = converter.ConvertToUSD(uahAmount);
        double eurAmount = converter.ConvertToEUR(uahAmount);
        double plnAmount = converter.ConvertToPLN(uahAmount);

        Console.WriteLine($"{uahAmount} UAH is equal to {usdAmount} USD");
        Console.WriteLine($"{uahAmount} UAH is equal to {eurAmount} EUR");
        Console.WriteLine($"{uahAmount} UAH is equal to {plnAmount} PLN");

        double convertedUSD = 50.0;
        double convertedEUR = 40.0;
        double convertedPLN = 70.0;

        double uahConvertedFromUSD = converter.ConvertFromUSD(convertedUSD);
        double uahConvertedFromEUR = converter.ConvertFromEUR(convertedEUR);
        double uahConvertedFromPLN = converter.ConvertFromPLN(convertedPLN);

        Console.WriteLine($"{convertedUSD} USD is equal to {uahConvertedFromUSD} UAH");
        Console.WriteLine($"{convertedEUR} EUR is equal to {uahConvertedFromEUR} UAH");
        Console.WriteLine($"{convertedPLN} PLN is equal to {uahConvertedFromPLN} UAH");

    }
}