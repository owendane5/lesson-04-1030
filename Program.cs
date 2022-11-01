namespace _3_pizzapicker;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Pizza Time!");

        int pepperoniCount = 0;
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;

        string options = @"Please Select the Pizzas you wish to order:
        1 - Pepperoni 
        2 - Hawaiian
        3 - Vegetarian
        4 - Cheese and Tomato
        ";

        Console.WriteLine(options);

        char selection = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (selection == '1') {
            pepperoniCount++;
        }
        else if (selection == '2') {
            hawaiianCount++;
        }
        else if (selection == '3') {
            vegetarianCount++;
        }
        else if (selection == '4') {
            cheeseCount++;
        }
        else {

        }


    }
}
