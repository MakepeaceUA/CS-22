namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Random random = new Random();
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    numbers.Add(random.Next(1, 1000)); 
            //}

            //List<int> Prime = numbers.Where(IsPrime).ToList();
            //List<int> Fibonacci = numbers.Where(IsFibonacci).ToList();

            //using (StringWriter PrimeWriter = new StringWriter())
            //{
            //    PrimeWriter.WriteLine(string.Join(", ", Prime));
            //    File.WriteAllText("prime_numbers.txt", PrimeWriter.ToString());
            //}
            //using (StringWriter FibonacciWriter = new StringWriter())
            //{
            //    FibonacciWriter.WriteLine(string.Join(", ", Fibonacci));
            //    File.WriteAllText("fibonacci_numbers.txt", FibonacciWriter.ToString());
            //}
            //Console.WriteLine("Количество цифр: " + numbers.Count);
            //Console.WriteLine("Простые числа: " + Prime.Count);
            //Console.WriteLine("Числа Фибоначчи: " + Fibonacci.Count);

            //Задание 2
            //List<string> arr = new List<string> { "word", "world", "house", "word", "house", "word" };

            //Console.Write("Введите путь к файлу: ");
            //string name = Console.ReadLine();

            //if (!File.Exists(name))
            //{
            //    File.WriteAllText(name, string.Join(", ", arr));
            //    Console.WriteLine("Файл создан.");
            //}

            //Console.Write("Введите слово для поиска: ");
            //string search = Console.ReadLine();
            //Console.Write("Введите слово для замены: ");
            //string replace = Console.ReadLine();

            //string content = File.ReadAllText(name);
            //if (content.Contains(search))
            //{
            //    int count = Count(content, search);

            //    string update = content.Replace(search, replace);
            //    File.WriteAllText(name, update);

            //    Console.WriteLine($"Произведено замен: {count}");
            //    Console.WriteLine("Файл успешно обновлен.");
            //}
            //else 
            //{
            //    Console.WriteLine("Ошибка.");
            //}

            //Задание 3
            //string WordsFilePath = "moderation_words.txt"; 
            //string TextFile = "text.txt"; 
            //if (!File.Exists(WordsFilePath))
            //{
            //    File.WriteAllText(WordsFilePath, "house\nmouse");
            //    Console.WriteLine($"Файл '{WordsFilePath}' создан с предустановленными словами для модерации.");
            //}
            //if (!File.Exists(TextFile))
            //{
            //    File.WriteAllText(TextFile, "test house rest car\nmouse telephone");
            //    Console.WriteLine($"Файл '{TextFile}' создан с предустановленным текстом.");
            //}
            //string[] moderationWords = File.ReadAllLines(WordsFilePath);
            //string[] textLines = File.ReadAllLines(TextFile);

            //StringWriter res = new StringWriter();

            //foreach (string line in textLines)
            //{
            //    string[] words = line.Split(' ');
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        for (int j = 0; j < moderationWords.Length; j++)
            //        {
            //            if (words[i].Equals(moderationWords[j]))
            //            {
            //                words[i] = new string('*', words[i].Length);
            //                break;
            //            }
            //        }
            //    }
            //    res.WriteLine(string.Join(" ", words));
            //}
            //string outputFilePath = "output.txt";
            //File.WriteAllText(outputFilePath, res.ToString());

            //Console.WriteLine($"Результат записан в {outputFilePath}");
        }
        //1
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //        return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        //static bool IsFibonacci(int number)
        //{
        //    int a = 0;
        //    int b = 1;
        //    while (b < number)
        //    {
        //        int temp = a;
        //        a = b;
        //        b = temp + b;
        //    }
        //    return b == number || number == 0;
        //}

        //2
        //static int Count(string text, string word)
        //{
        //    int count = 0;
        //    int index = 0;

        //    while ((index = text.IndexOf(word, index)) != -1)
        //    {
        //        count++;
        //        index += word.Length;
        //    }
        //    return count;
        //}
    }


}
