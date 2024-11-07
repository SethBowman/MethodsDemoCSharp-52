namespace MethodsDemoCSharp_52;

class Program
{
    //Create a method here
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // string userInput = Console.ReadLine();
        
        //Call the method (using the method)
        GreetPerson("Seth");
        GreetPerson("Logan");

        int sum = AddTwoNumbers(73974, 2321);
        Console.WriteLine(sum);
    }
    
    //Or create a method here
    //Method definition (creating a method)
    //Pascal casing for methods
    public static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int AddTwoNumbers(int numOne, int numTwo)
    {
        //int sum = numOne + numTwo;

        return numOne + numTwo;
    }
}
