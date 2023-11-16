internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Birinci sayıyı girin:");
        //double firstNumber = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("İkinci sayıyı girin:");
        //double secondNumber = Convert.ToDouble(Console.ReadLine());
        //string[] names = { "Ahmet", "Mehmet", "John" };
        //int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int[] numbers2 = new int[100];
        List<int> numbers = new List<int>();

        //Console.WriteLine("Kaç sayı girmek istiyorsunuz?");
        //int count = Convert.ToInt32(Console.ReadLine());

        //double[] numbers = new double[count];



        //// boş, 1, 1, 2, 4, 7
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine((i + 1) + ". Sayıyı girin");
        //    double number = Convert.ToDouble(Console.ReadLine());
        //    numbers[i] = number;
        //}

        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}

        while (true)
        {

            Console.WriteLine("Sayı girin veya exit yazın");
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            else
            {
                //numbers[counter] = Convert.ToInt32(input);
                numbers.Add(Convert.ToInt32(input));
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine(total);




        //Console.WriteLine("Yapmak İstedğiniz İşlemi Seçin:\n +, -, *, /");
        //string operation = Console.ReadLine();
        //if (operation == "+")
        //{
        //    // 3 Sayı topla
        //    Console.WriteLine("Üçüncü Sayıyı Girin: ");


        //    double thirdNumber = Convert.ToDouble(Console.ReadLine());
        //    double result = AddNumbers(firstNumber, secondNumber, thirdNumber);
        //    Console.Clear();
        //    Console.WriteLine(result);

        //}
        //else if (operation == "-")
        //{
        //    // Çıkarma
        //    double result = SubtractNumbers(firstNumber, secondNumber);
        //    Console.Clear();
        //    Console.WriteLine(result);
        //}
        //else if (operation == "*")
        //{
        //    // Çarpma
        //    double result = MultiplyNumbers(firstNumber, secondNumber);
        //    Console.Clear();
        //    Console.WriteLine(result);
        //}
        //else if (operation == "/")
        //{
        //    // Bölme
        //    double result = DivideNumbers(firstNumber, secondNumber);
        //    Console.Clear();
        //    Console.WriteLine(result);

        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}

        Console.ReadLine();
        
        ////double result = AddNumbers(firstNumber, secondNumber);
        //Console.WriteLine("Toplam = " + result);



    }

    // (Dönüş Türü) (Metot İsmi) (Parametreler)

    static double AddNumbers(double number1, double number2, double number3)
    {
        return number1 + number2 + number3;
    }

    static double SubtractNumbers(double number1, double number2)
    {
        return number1 - number2;
    }

    static double MultiplyNumbers(double number1, double number2)
    {
        return number1 * number2;
    }

    static double DivideNumbers(double number1, double number2)
    {
        double sonuc = number1 / number2;
        return (sonuc);
    }


}
