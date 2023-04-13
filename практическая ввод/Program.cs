namespace практическая_ввод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ф.И.О: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите mail: ");
            string mail = Console.ReadLine();
            Console.WriteLine("Введите баллы по математике: ");
            double program = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите баллы по программированию: ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите баллы по физике: ");
            double phys = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ф.И.О.: {fullName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"mail {mail}");
            Console.WriteLine($"Баллы по программированию: {program}");
            Console.WriteLine($"Баллы по математике: {math}");
            Console.WriteLine($"Баллы по физике: {phys}");
            Console.ReadLine();
        }
    }
}