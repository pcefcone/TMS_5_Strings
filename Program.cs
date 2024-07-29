using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System;
using TMS_5_Strings;

internal class Program
{
    private static void Main(string[] args)
    {
        //Если нужно чтение файла
        //string text = File.ReadAllText("тут путь к файлу");
        //string input = "2343-ggh-1233-wtw-0g5k";
        Console.WriteLine("put text here:");
        string input = Console.ReadLine();
        var arrayWords = input.Split(new char[] {' ', ',', '.', '!', '?', '-'});
        var result = string.Empty;
        var counter = 0;
        var maxCount = 0;


        StringMethods.replaceNumbersToWords(input);
        StringMethods.findLongestWord(input);
        StringMethods.FindWordWhichConsistMaxNumbers(input);



       
        /*

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        Console.ReadKey();
        replaceNumbersToWords(input);
        Console.ReadKey();
        findLongestWord(input);
        */




    }
}