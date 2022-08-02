// This is an app to Calculate Area of room

//Welcome Text - explaining whats up
Console.WriteLine("***** ----------------------------------------------- *****");
Console.WriteLine("***** Welcome to Grand Circus’ Room Detail Generator! *****");
Console.WriteLine("***** ----------------------------------------------- *****");

Console.WriteLine();

//
//print a line to ask for width

Console.Write("Enter Room Length: ");

//readline to decimal var
decimal rLength = Convert.ToDecimal(Console.ReadLine());


//print a line to ask for Width

Console.WriteLine();
Console.Write("Enter Room Width: ");

//readline to decimal var

decimal rWidth = Convert.ToDecimal(Console.ReadLine());

//ask for height

Console.WriteLine();
Console.Write("Enter Room Height: ");

//readline to decimal var

decimal rHeight = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($" ");
Console.WriteLine($" ");


//do some math

decimal rArea = rWidth * rLength;
decimal rPerim = 2*(rWidth + rLength);
decimal rVolume = (rHeight * rWidth * rLength);

//evaluate whether small, medium or large
//print evaluation

if (rArea > 0)
{
    if (rArea > 250)
    {
        if(rArea > 650)
        {
            Console.WriteLine("This is a Large-Sized room.");
            Console.WriteLine($" ");
            
        } else
        {
            Console.WriteLine("This is a Medium-Sized room.");
            Console.WriteLine($" ");
        }
    }
    else
    {
        Console.WriteLine("This is a Small-Sized room.");
        Console.WriteLine($" ");
    }
}
else
{
    Console.WriteLine("Error: User Entered Invalid Data!!! Use Non-Imaginary Numbers!");
}



//print some math

Console.WriteLine($"Area: calculated {rArea}");
Console.WriteLine($"Perimeter: calculated {rPerim}");
Console.WriteLine($"Volume: calculated {rVolume}");
Console.WriteLine($"Surface Area: calculated {(2*(rLength*rWidth))+ (2 * (rLength*rHeight)) + (2 * (rHeight*rWidth))}");
Console.WriteLine($" ");
Console.WriteLine($" ");
Console.WriteLine("*****  Thank you for using the Room Detail Generator! *****");
Console.WriteLine("***** ----------------------------------------------- *****");
Console.WriteLine($" ");
Console.WriteLine($" ");

/*example display
 * 
 * Welcome to Grand Circus’ Room Detail Generator! 
 * Enter Length: {user input here, for example: 24.5} 
 * Enter Width: {user input here, for example: 20} 
 * Area: {calculated: 490}
 * Perimeter: {calculated: 89 }
 * {calculated: This is a medium-sized room.}
 * Thank you for using the Room Detail Generator!
 * 
 */