// Number Analyzer
// Objectives - User Input and Conditionals

//Intro Fluff
static void PrintHead(){
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("*****   ----------------------------------------   *****");
    Console.WriteLine("*****   ----DevBuild 8 Number Analyzer v1.0 ----   *****");
    Console.WriteLine("*****   ----------------------------------------   *****");
    Console.WriteLine();
    Console.WriteLine();
}

PrintHead();

// ask user name - save as variable (will this be available for the entire program?) - was told not to do - but seemed fun.
Console.Write("Please enter user name: ");
string uName = Console.ReadLine();

PrintHead();

Console.WriteLine($"Welcome, {uName}!");

bool uVerify = false;
int uNum;
string uInput;

bool goAgain = true;
//begin Do While for "Would you like to go again"


while (goAgain == true)
{

    do
    {
        // write a prompt for a number between 1 and 100 - readline
        Console.WriteLine();
        Console.Write($"Please Enter a number between 1 and 100: ");
        uInput = (Console.ReadLine());
        //check if valid data type, else, tsk tsk and ask again
        //check if number is between 1 - 100, else go back to prompt after a quick tsk tsk for the user

        if (int.TryParse(uInput, out uNum) && uNum >= 1 && uNum <= 100)
        {

            uVerify = true;

        }
        else
        {
            uVerify = false;


            PrintHead();

            Console.Write($"{uName}, that is an Invalid entry...\n\nPlease try again...");
            Console.WriteLine();

        }
    } while (!uVerify);



    // Begin Checking all Conditions
    //Sort 2 Switch Trees nested within an if/else - one for even, one for odd (use remainder of input/2 to judge if even or odd)

    PrintHead();
    Console.WriteLine();
    Thread.Sleep(250);
    for (int i = 1; i < 20; i++)
    {
        Console.Write(" . ");
        Thread.Sleep(100);
    }
    PrintHead();
    Console.Write($"{uNum} is ");

    if (uNum % 2 != 0)
    {
        Console.Write("Odd and ");
        //Odd Tree - less than 60 - greater than 60 (was not asked to account for 60 on the nose)
        switch (uNum)
        {
            case < 60:
                Console.Write("less than 60!");
                Console.WriteLine();
                break;
            case > 60:
                Console.Write("greater than 60!");
                Console.WriteLine();
                break;
            default:
                Console.Write("Valid.");
                Console.WriteLine();
                break;
        }

    }
    else
    {
        Console.Write("Even and ");
        //Even Tree - 2-24, 26-60,  60+ 
        switch (uNum)
        {
            case <= 24:
                Console.Write("less than 25!");
                Console.WriteLine();
                break;
            case >= 25:
                if (uNum <= 60)
                {
                    Console.Write("between 26 and 60!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.Write($"greater than 60!");
                    Console.WriteLine();
                    break;
                };


            default:
                Console.Write("Valid.");
                Console.WriteLine();
                break;
        }

    }

    Thread.Sleep(500);
    Console.WriteLine();
    bool uValidResponse = false;
    do
    {
        Console.WriteLine($"Would you like to try another number, {uName}?");
        Thread.Sleep(125);
        Console.WriteLine();
        Console.Write("Y or N: ");
        string uResponse = Console.ReadLine().ToLower();
        if (uResponse != null)
        {
            switch (uResponse)
            {
                case "y":
                    uValidResponse = true;
                    goAgain = true;
                    break;
                case "yes":
                    uValidResponse = true;
                    goAgain = true;
                    break;
                case "n":
                    uValidResponse = true;
                    goAgain = false;
                    break;
                case "no":
                    uValidResponse = true;
                    goAgain = false;
                    break;


                default:
                    uValidResponse = false;
                    Console.WriteLine("Invalid Response! Please Try Again...");
                    Thread.Sleep(1500);
                    PrintHead();
                    break;

            }
        }
    } while (!uValidResponse);
}
Console.WriteLine();
Console.WriteLine($"Good Bye, {uName}");
Thread.Sleep(2500);
Console.Clear();






//Would you like to go again -  input

//Validate y/n input -- and loop back to y/n prompt if incorrect.

//add While statement for Prime containing do/while

