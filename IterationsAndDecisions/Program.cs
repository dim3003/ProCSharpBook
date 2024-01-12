// A basic for loop.
static void ForLoopExample()
{
    // Note! "i" is only visible within the scope of the for loop.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0} ", i);
    }
    // "i" is not visible here.
}

// Iterate arrays items using foreach.
static void ForeachLoopExample()
{
    // Create an array of strings.
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };

    // Loop over strings in array.
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }
    // "c" is not visible here.
}

static void whileLoopExample()
{
    string userIsDone = "";

    // Test on a lower-class copy of the string.
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }
}

static void doWhileLoopExample()
{
    string userIsDone = "";

    do
    {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
}

static void IfElsePatternMatching()
{
    // Test if we can assign "p" to "var" of type object.
    object test = "test";
    if (test is string p)
    {
        // Use "p" in scope.
        Console.WriteLine(p);
    }
    else
    {
        // Can't use "p" here.
        Console.WriteLine("Failed to convert.");
    }
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("====== C# 9 If Else Pattern Matching Improvements ======");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';

    // Type pattern
    if(t is Type)
    {
        Console.WriteLine("t is Type");
    }

    // Relational, Conjuctive and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine("c is a character");
    };

    // Parenthesized patterns
    if ( c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
           Console.WriteLine("c is a character or separator");
    };

    // Negative patterns
    if(testItem1 is not string)
    {
        Console.WriteLine("testItem1 is not a string");
    }
}

static void SwitchWithGoto()
{
    var foo = 5;
    switch (foo)
    {
        case 1:
            Console.WriteLine("1");
            goto case 2;
        case 2:
            Console.WriteLine("2");
            goto case 3;
        case 3:
            Console.WriteLine("3");
            goto default;
        default:
            Console.WriteLine("Default");
            break;
    }
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

    switch (choice)
    {
        case int i when i == 2:
            Console.WriteLine("VB .NET: OOP, multithreading and more!");
            break;
        case int i when i == 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}

static string FromRainbowClassic(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#8F00FF",
        _ => "#FFFFFF", // white
    };
}

// Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };
}
