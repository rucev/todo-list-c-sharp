Console.WriteLine("Hello!");

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
            Console.WriteLine("See all");
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




