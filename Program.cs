Console.WriteLine("Please Write Your Name");
string? name = ReadInput();
DateTime date = DateTime.UtcNow;

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

if (userSelection == "a")
{
    AdditionGame();
}
else if (userSelection == "s")
{
    SubtractionGame();
}
else if (userSelection == "m")
{
    MultiplicationGame();
}
else if (userSelection == "d")
{
    DivisionGame();
}
else if (userSelection == "q")
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("No such option in the menu!");
}

string ReadInput()
{
    bool isValidInput = false;
    string? userInput;
    do
    {
        userInput = Console.ReadLine();
        if (userInput != null)
        {
            isValidInput = true;
        }
    } while (isValidInput);
    return userInput;
}

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