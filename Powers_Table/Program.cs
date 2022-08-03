// Powers_Table
// Objectives - User Input and Conditionals

static void PowerTable(int pNum)
{

    // Call PrintHead()

    //Format Table

    Console.WriteLine("|-------------------[Powers Table]---------------------|\n");
    Console.WriteLine("\t {0,10} {1,10} {2,10}", "[Number]", "[Square]", "[Cube]");
    Console.WriteLine();
    // Print the Output from a loop

    for (int i = 1; i <= pNum; i++)
    {

        Console.WriteLine("\t {0, 10} {1, 10} {2,10} ", i, i*i, Math.Pow(i, 3));
    }
}

//Intro Fluff
static void PrintHead()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("*****   ----------------------------------------   *****");
    Console.WriteLine("*****   ----    DevBuild 8 Powers Table     ----   *****");
    Console.WriteLine("*****   ----------------------------------------   *****");
    Console.WriteLine();
}

PrintHead();


bool uVerify = false;
int uNum;
string uInput;

bool goAgain = true;
//begin Do While for "Would you like to go again"


while (goAgain == true)
{

    do
    {
        // write a prompt for an int
        Console.WriteLine();
        Console.Write("\t Please Enter a whole positive number: ");
        uInput = (Console.ReadLine());
        //check if valid data type, else, tsk tsk and ask again
        //check if number is between 1 - 100, else go back to prompt after a quick tsk tsk for the user

        if (int.TryParse(uInput, out uNum) && uNum >= 1 && uNum <= 2147483647)
        {

            uVerify = true;

        }
        else
        {
            uVerify = false;


            PrintHead();

            Console.Write($"That is an Invalid entry...\n\nPlease try again...");
            Console.WriteLine();

        }
    } while (!uVerify);



    // Begin Checking all Conditions
    // Print Table

    PrintHead();
    Console.WriteLine();
    Thread.Sleep(250);

    //Analyze and Print Table
    PowerTable(uNum);
    //Call Function?

    Thread.Sleep(500);
    Console.WriteLine();
    bool uValidResponse = false;
    do
    {
        Console.WriteLine($"\t Would you like to try another number?");
        Thread.Sleep(125);
        Console.WriteLine();
        Console.Write("\t \t Y or N: ");
        string uResponse = Console.ReadLine().ToLower();
        if (uResponse != null)
        {
            switch (uResponse)
            {
                case "y":
                    uValidResponse = true;
                    goAgain = true;
                    PrintHead();
                    break;
                case "yes":
                    uValidResponse = true;
                    goAgain = true;
                    PrintHead();
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
                    Console.WriteLine("\t Invalid Response! Please Try Again...");
                    Thread.Sleep(1500);
                    PrintHead();
                    break;

            }
        }
    } while (!uValidResponse);
}
Console.WriteLine();
Console.WriteLine($"\t Good Bye!");
Thread.Sleep(2500);
Console.Clear();






//Would you like to go again -  input

//Validate y/n input -- and loop back to y/n prompt if incorrect.

//add While statement for Prime containing do/while

