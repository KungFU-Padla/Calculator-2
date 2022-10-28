
    class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            double firstNumber, secondNumber;
            string action;

            Console.WriteLine("Введите число 1");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/' 'f' '1%' ");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)

                        Console.WriteLine(0);

                    else

                        Console.WriteLine(firstNumber / secondNumber);
                   break;
                case "f":
                  
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Вы выбрали:число 8:(Найти факториал из числа)");
                        Console.WriteLine("Введите число из которого вы хотите найти факториал:");
                        string f = Console.ReadLine();
                        int f2 = Convert.ToInt32(f);
                        int d = 1;
                        for (int z = 2; f2 >= z; z++)
                        {
                            d = d * z;
                        }
                        Console.WriteLine("Ответ:" + d);
                    }
                    break;
                case "1%":
                    
                  
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите процент от числа, что Вам нужен");
                    double prots = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine((a / 100) * prots);
                    
                    break;
                   

                default:
                    Console.WriteLine("Ошибка!");
                    break;




            }
            Console.ReadLine();


        }
    }



}







