TASK_1_CALCULATOR
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 4;
            double num2 = 5;
            Console.WriteLine($"Сложение: {Calculator.Add(num1, num2)}");
            Console.WriteLine($"Вычитание: {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Умножение: {Calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Деление: {Calculator.Divide(num1, num2)}");
        }                
    }
}
TASK_2_ProgrqamConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConfig.ProgramInfo();
        }
    }
}
TASK_3_ObjectCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectCounter num1 = new ObjectCounter();
            ObjectCounter num2 = new ObjectCounter();
            Console.WriteLine($"Создано объектов: {ObjectCounter.GetCounter()}");
        }
    }
}
TASK_4_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("55", "Василий", "123456");
            Console.WriteLine(book1.GetBookInfo());
        }
    }
}
TASK_5_Settings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.PrintConfigPath();
        }
    }
}
