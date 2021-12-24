// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine("You are: " + userName);
Console.WriteLine("How much money do you have? ");
string Balance = Console.ReadLine();
float startBalance = float.Parse(Balance);

Console.WriteLine(userName + ", your balance is " + startBalance + " EUR");
Console.WriteLine("Press 1 for WITHDRAWAL");
Console.WriteLine("Press 2 for DEPOSIT");


if (Console.ReadKey().Key == ConsoleKey.NumPad1)
{
    Console.ReadLine();
    Console.WriteLine("How much money do you wish to withdraw? ");
    string Withdrawal = Console.ReadLine();
    float wBalance = float.Parse(Withdrawal);

    Console.WriteLine("Your new balance is " + (startBalance - wBalance) + " EUR");
    Console.ReadLine();
    Environment.Exit(0);

} 



if (Console.ReadKey().Key == ConsoleKey.NumPad2)
{
    Console.ReadLine();
    Console.WriteLine("How much money do you wish to deposit? ");
    string Deposit = Console.ReadLine();
    float dBalance = float.Parse(Deposit);

    Console.WriteLine("Your new balance is " + (startBalance - dBalance) + " EUR");
    Console.ReadLine();
    Environment.Exit(0);

}

else Console.WriteLine("There was no choice for this number");










