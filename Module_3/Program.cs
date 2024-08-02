namespace Module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter your birthday: ");
            var birthday = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.WriteLine("Your birthday is {0}", birthday);
        }
    }
}
