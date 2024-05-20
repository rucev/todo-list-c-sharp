Console.WriteLine("Hello!");

var todos = new List<string>();

void SeeAll()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("Nothing to do.");
    }
    else
    {
        int todoNumber = 1;
        foreach (string todo in todos)
        {
            Console.WriteLine($"{todoNumber}: {todo}");
            ++todoNumber;
        }
    }
}

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "E":
        case "e":
            isRunning = false;
            break;
        case "S":
        case "s":
            SeeAll();
            break;
        case "A":
        case "a":
            Console.WriteLine("Add to do");
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove to do");
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    if (userInput == "e" || userInput == "E")
    {
        Console.WriteLine("Bye!");
    }
    else
    {
        Console.WriteLine("Something else?");
    }
}




