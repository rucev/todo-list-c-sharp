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
            Console.WriteLine($"[{todoNumber}] {todo}");
            ++todoNumber;
        }
    }
}

void AddTodo()
{
    Console.WriteLine("What do you need to do?");
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        Console.WriteLine("Invalid Input!");
    }
    else
    {
        todos.Add(userInput);
        Console.WriteLine("Todo added to the list!");
    }
}

void RemoveTodo()
{
    Console.WriteLine("Select todo to delete:");
    SeeAll();
    if (todos.Count == 0)
    {
        return;
    }
    var userInput = Console.ReadLine();
    var index = 0;
    bool isParsable = int.TryParse(userInput, out index);

    while (!isParsable || index - 1 > todos.Count)
    {
        Console.WriteLine("Please, select a valid option.");
        var newUserInput = Console.ReadLine();
        isParsable = int.TryParse(newUserInput, out index);
    }
    todos.RemoveAt(index - 1);
    Console.WriteLine("Updated list:");
    SeeAll();
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
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
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