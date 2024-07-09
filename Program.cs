using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System;

internal class Program
{
    public static void replaceNumbersToWords(string input)
    {
        string input1 = input
            .Replace("1", "ONE")
            .Replace("2", "TWO")
            .Replace("3", "THREE")
            .Replace("4", "FOUR")
            .Replace("5", "FIVE")
            .Replace("6", "SIX")
            .Replace("7", "SEVEN")
            .Replace("8", "EIGHT")
            .Replace("9", "NINE")
            .Replace("0", "ZERO");
                              

        Console.WriteLine(input1);
    }
    public static void findLongestWord(string input)
    {
        string[] exclusionСharacters = input.Split(' ', ',', '.', ':', '!', '?', ';');
        int maxlen = 0, index = 0;
        for (int i = 0; i < exclusionСharacters.Length; i++)
        {
            if (exclusionСharacters[i].Length > maxlen)
            {
                maxlen = exclusionСharacters[i].Length;
                index = i;
                //bool isCont = input.Contains(str[index]);
            }
        }
        int gg = 0;

        Console.Write("Самое длинное слово: {0}", exclusionСharacters[index]);
        string searchWord = exclusionСharacters[index];
        char[] separators = [' ', ',', '.', ':', '!', '?', ';'];
        string[] source = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var matchQuery = from word in source
                         where word.Equals(searchWord, StringComparison.InvariantCultureIgnoreCase)
                         select word;

        int wordCount = matchQuery.Count();
        Console.WriteLine($"\nСлово {searchWord} встречается {wordCount} раз");
    }
    private static void Main(string[] args)
    {
            //string[] num1 = input.Split( '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            //char[] num = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
        //Считать строку текста из консоли(продвинутое задание: из файла).
        //test
        //string inputData = "Hello worldf!";
        //string[] words = inputData.Split(',', ' ', '-', ';', '!', '?', ':');
        ////int max = words.Select(word => word.Length).Max();



        {       
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.ReadKey();
            replaceNumbersToWords(input);
            Console.ReadKey();
            findLongestWord(input);
            
           

            //string searchNumber = str[index];
            //string[] source2 = input.Split(num, StringSplitOptions.RemoveEmptyEntries);
            //var matchNums = from word in source2
            //                  where word.Equals(num, StringComparison.InvariantCultureIgnoreCase)
            //                  select word;
            //int numsCount = matchNums.Count();
            //Console.WriteLine($"\nВ тексте встречаются цифры {numsCount} раз");


        }

        


        //string a = "a";
        //bool result = false;
        //string result1;
        //result = inputData.StartsWith("Hello");
        //Console.WriteLine(result);
        //result = inputData.Contains("H");
        //Console.WriteLine(result);
        //result1 = inputData.Insert(5, "1");
        //Console.WriteLine(result1);


        //Строка содержит буквы латинского алфавита, знаки препинания и цифры.
        //Реализовать меню выбора действий:
        //-Найти слова, содержащие максимальное количество цифр.
        //-Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
        //-Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
        //-Вывести на экран сначала вопросительные, а затем восклицательные предложения.
        //- Вывести на экран только предложения, не содержащие запятых.
        //-Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.


        //        Домашнее задание
        //Основное задание
        //1.Написать программу со следующим функционалом:
        //На вход передать строку(будем считать, что это номер документа).
        //Номер документа имеет формат xxxx - yyy - xxxx - yyy - xyxy, где x — это число,
        //а y — это буква.
        //-Вывести на экран в одну строку два первых блока по 4 цифры.
        //- Вывести на экран номер документа, но блоки из трех букв заменить
        //на * **(каждая буква заменятся на *).
        //-Вывести на экран только одни буквы из номера документа в формате
        //yyy / yyy / y / y в нижнем регистре.
        //- Вывести на экран буквы из номера документа в формате
        //"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
        //класса StringBuilder).
        //- Проверить содержит ли номер документа последовательность abc и
        //вывети сообщение содержит или нет(причем, abc и ABC считается
        //одинаковой последовательностью).
        //-Проверить начинается ли номер документа с последовательности
        //555.
        //- Проверить заканчивается ли номер документа на
        //последовательность 1a2b.
        //Все эти методы реализовать в отдельном классе в статических методах,
        //которые на вход(входным параметром) будут принимать вводимую на вход
        //программы строку.
        //Дополнительное задание
        //teachmeskills.by
        //2.Дана строка произвольной длины с произвольными
        //словами.
        //Найти самое короткое слово в строке и вывести его на экран.
        //Найти самое длинное слово в строке и вывести его на экран.
        //Если таких слов несколько, то вывести последнее из них.
        //3.Дана строка произвольной длины с произвольными словами.
        //Найти слово, в котором число различных символов минимально.Слово
        //может содержать буквы и цифры. Если таких слов несколько, найти первое
        //из них.Например, в строке "fffff ab f 1234 jkjk" найденное слово должно
        //быть "fffff".
        //4.Дана строка произвольной длины с произвольными словами.
        //Написать программу для проверки является ли любое выбранное слово в
        //строке палиндромом.
        //Например, есть строка, вводится число 3, значит необходимо проверить
        //является ли 3 - е слово в этой строке палиндромом.
        //Предусмотреть предупреждающие сообщения на случаи ошибочных
        //ситуаций: например, в строке 5 слов, а на вход программе передали число
        //500 и т. п.ситуации.
        //5.Дана произвольная строка.
        //Вывести на консоль новую строку, которой задублирована каждая буква из
        //начальной строки.
        //Например, "Hello"-> "HHeelllloo".

    }
}