/* 
Basic math game where users can answer randomly generated questions based on the operations of adding, subtracting, multiplying, and dividing. 
Previous questions are stored and can be viewed via the main menu. 
Results are deleted once the program is closed.
 */

string menuSelection = "";
string? readResult;
string? answer;
var rand = new Random();
List<string> questions = [];
int randIntOne;
int randIntTwo;

do
{
    Console.WriteLine("\nMath Game");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. View Past Questions");
    Console.WriteLine("6. Exit");
    Console.WriteLine("Enter 1, 2, 3, or 4 to get a random math question to answer. Enter 5 to view past questions. Or enter 6 to exit the program.");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult;
    }
    switch (menuSelection)
    {
        // Handles addition functionality
        case "1":
            randIntOne = rand.Next(1, 1000);
            randIntTwo = rand.Next(1, 1000);
            Console.WriteLine($"What is {randIntOne} + {randIntTwo}?");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out int numAdd))
            {
                if (randIntOne + randIntTwo == numAdd)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            questions.Add($"{randIntOne} + {randIntTwo} = {randIntOne + randIntTwo}");
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            Console.Clear();
            break;
        // Handles subtraction functionality
        case "2":
            randIntOne = rand.Next(1, 1000);
            randIntTwo = rand.Next(1, 1000);
            Console.WriteLine($"What is {randIntOne} - {randIntTwo}?");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out int numSub))
            {
                if (randIntOne - randIntTwo == numSub)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            questions.Add($"{randIntOne} - {randIntTwo} = {randIntOne - randIntTwo}");
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            Console.Clear();
            break;
        // Handles multiplication functionality
        case "3":
            randIntOne = rand.Next(1, 16);
            randIntTwo = rand.Next(1, 16);
            Console.WriteLine($"What is {randIntOne} * {randIntTwo}?");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out int numMult))
            {
                if (randIntOne * randIntTwo == numMult)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            questions.Add($"{randIntOne} * {randIntTwo} = {randIntOne * randIntTwo}");
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            Console.Clear();
            break;
        /* 
        Handles division functionality
        Randomly generates integers until answer is a whole integer
         */
        case "4":
            randIntOne = rand.Next(1, 1000);
            randIntTwo = rand.Next(1, 100);
            while ((randIntOne % randIntTwo) != 0)
            {
                randIntOne = rand.Next(1, 1000);
                randIntTwo = rand.Next(1, 100);
            }
            Console.WriteLine($"What is {randIntOne} / {randIntTwo}?");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out int numDiv))
            {
                if (randIntOne / randIntTwo == numDiv)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            questions.Add($"{randIntOne} / {randIntTwo} = {randIntOne / randIntTwo}");
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            Console.Clear();
            break;
        // View past questions
        case "5":
            if (questions.Count != 0)
                questions.ForEach(Console.WriteLine);
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            Console.Clear();
            break;
        case "6":
            Console.WriteLine("Exiting program.");
            break;
        default:
            Console.WriteLine("Invalid input. Please try again.");
            break;
    }

} while (menuSelection != "6");