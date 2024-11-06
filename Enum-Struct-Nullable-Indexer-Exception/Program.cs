using Enum_Struct_Nullable_Indexer_Exception.Exceptions;

namespace Enum_Struct_Nullable_Indexer_Exception;
class Program
{
    static void Main(string[] args)
    {
        Person[] person = new Person[2];
        person[0] = new Person("Laman", "Aliyeva", 26);
        person[1] = new Person("Ali", "Mamedov", 23);
        Console.WriteLine(person[0] >= person[1]);

        throw new CapacityLimitException("nsjkdnks");

    }

    public static double Exchange(Currency currency, double azn)
    {
        double result = 1;
        switch (currency)
        {
            case Currency.USD:
                result = azn * 0.59;
                break;
            case Currency.Euro:
                result = azn * 0.54;
                break;
            case Currency.TRY:
                result = azn * 20.18;
                break;
            default:
                Console.WriteLine("Enter another currency");
                break;
        }
        return result;
    }

}
