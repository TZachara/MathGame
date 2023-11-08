Console.WriteLine("Please Write Your Name");
string? name = ReadInput();
DateTime date = DateTime.UtcNow;

List<string> games = new List<string>();

Menu(name, date);

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        int result = Convert.ToInt32(Console.ReadLine());

        if (result == firstNumber + secondNumber)
        {
            Console.WriteLine("Your anwser was correct! Type any key to continue.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your anwser was wrong! Type any key to continue.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over! Your score is {score}. Type any key to continue.");
            Console.ReadLine();
        }
    }
    ArchiveGame("Addition", score);
}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        int result = Convert.ToInt32(Console.ReadLine());

        if (result == firstNumber - secondNumber)
        {
            Console.WriteLine("Your anwser was correct! Type any key to continue.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your anwser was wrong! Type any key to continue.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over! Your score is {score}. Type any key to continue.");
            Console.ReadLine();
        }
    }
    ArchiveGame("Subtraction", score);
}

void MultiplicationGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        int result = Convert.ToInt32(Console.ReadLine());

        if (result == firstNumber * secondNumber)
        {
            Console.WriteLine("Your anwser was correct! Type any key to continue.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your anwser was wrong! Type any key to continue.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over! Your score is {score}. Type any key to continue.");
            Console.ReadLine();
        }
    }
    ArchiveGame("Multiplication", score);
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumber();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        int result = Convert.ToInt32(Console.ReadLine());

        if (result == firstNumber / secondNumber)
        {
            Console.WriteLine("Your anwser was correct! Type any key to continue.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your anwser was wrong! Type any key to continue.");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over! Your score is {score}. Type any key to continue.");
            Console.ReadLine();
        }
    }
    ArchiveGame("Division", score);
}

void Menu(string name, DateTime date)
{
    bool isGameOn = true;
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is Your Math game");
    do
    {
        Console.Clear();
        Console.WriteLine(@$"What game would You like to play today? Choose from the option below:
                            V - View Previous Games
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
                AdditionGame("Addition Game!");
                break;
            case "s":
                SubtractionGame("Subtraction Game!");
                break;
            case "m":
                MultiplicationGame("Multiplication Game!");
                break;
            case "d":
                DivisionGame("Division Game!");
                break;
            case "q":
                Console.WriteLine("Goodbye!");
                isGameOn = false;
                break;
            case "v":
                GetGames();
                break;
            default:
                Console.WriteLine("No such option in the menu!");
                break;
        }
    } while (isGameOn);
}

int[] GetDivisionNumber()
{
    Random random = new Random();
    int[] result = new int[2];
    result[0] = random.Next(1, 99);
    result[1] = random.Next(1, 99);
    while (result[0] % result[1] != 0)
    {
        result[0] = random.Next(1, 99);
        result[1] = random.Next(1, 99);
    }
    return result;
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

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Game History");
    Console.WriteLine("------------------------------------------------------------------------");
    foreach (string game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine("Type any key to continue.");
    Console.ReadLine();
}

void ArchiveGame(string gameType, int score)
{
    games.Add($"{DateTime.UtcNow} - {gameType} - Score = {score}");
}