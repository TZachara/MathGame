Console.WriteLine("Please Write Your Name");
string? name = ReadInput();
DateTime date = DateTime.UtcNow;


Menu(name, date);

void AdditionGame()
{
    Console.WriteLine("Addition Game Selected");
}
void SubtractionGame()
{
    Console.WriteLine("Subtraction Game Selected");
}
void MultiplicationGame()
{
    Console.WriteLine("Multiplication Game Selected");
}
void DivisionGame()
{
    Console.WriteLine("Division Game Selected");
}

void Menu(string name, DateTime date)
{
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is Your Math game");
    Console.WriteLine(@$"What game would You like to play today?Choose from the option below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit program");
    Console.WriteLine("------------------------------------------------------------------------");

    string? userSelection = ReadInput().Trim().ToLower();

    switch (userSelection)
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "q":
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("No such option in the menu!");
            break;
    }

}
string ReadInput()
{
    bool isValidInput = false;
    string? userInput;
    do
    {
        userInput = Console.ReadLine();
        if (userInput != null && userInput != "")
        {
            isValidInput = true;
        }
    } while (!isValidInput);
    return userInput;
}