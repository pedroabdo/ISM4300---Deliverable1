namespace deliverable_helloworld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Type out your user name ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user name is: " + userName);

            Console.WriteLine("Type out your user's age ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + userAge);
        }
    }
}