// See https://aka.ms/new-console-template for more information
float Balance = 1000;

Console.WriteLine("What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine("You are: " + userName);
Console.WriteLine("");
Console.WriteLine(userName + ", your balance is " + Balance + " EUR");

Console.WriteLine("How much money do you wish to withdraw? ");
string sBalance = Console.ReadLine();
float newBalance = float.Parse(sBalance);

Console.WriteLine("Your new balance is " + (Balance - newBalance) + " EUR");









