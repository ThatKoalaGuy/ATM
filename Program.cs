static float ReadFloat(string responses)
{
    // keep asking user...
    while (true)
    {
        if (!string.IsNullOrWhiteSpace(responses))
            Console.WriteLine(responses);

        if (!float.TryParse(Console.ReadLine(), out float result))
            Console.WriteLine("Syntax error. Please, try again.");
        else if (result < 0)
            Console.WriteLine("Negative sum is not allowed. Please, try again.");
        else
            return result; // ... until valid value is provided
    }
}



Console.WriteLine("What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine("You are: " + userName);
Console.WriteLine("How much money do you have in the bank? ");
string Balance = Console.ReadLine();

float startBalance = float.Parse(Balance);

    Console.WriteLine("Press 1 for WITHDRAWAL");
    Console.WriteLine("Press 2 for DEPOSIT");

    // Ask user once - Console.ReadKey().Key - then operate with his/her choice 
    var choice = Console.ReadKey().Key;
    Console.ReadKey();

// balance change (either negative - withdraw or positive - deposit)
float delta =
    choice == ConsoleKey.NumPad1 ? -ReadFloat("How much money do you wish to withdraw?")
  : choice == ConsoleKey.NumPad2 ? ReadFloat("How much money do you wish to deposit?")
  : 0f;

    if (delta != 0)
    {
        Console.WriteLine($"Your new balance is {startBalance + delta} EUR");
        Console.ReadLine();
        Environment.Exit(0);
    }

    else
        Console.WriteLine("There was no choice for this number, please take you credit card out of the ATM");










