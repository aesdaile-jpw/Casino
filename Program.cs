// See https://aka.ms/new-console-template for more information
using Casino;

double odds = 0.75;
Guy guy = new Guy() { Cash =100, Name = "The Player" };
Console.WriteLine( "Welcome to the casino, " + guy.Name + "! /n The odds today are " + odds );
while ( true )
{
    guy.WriteMyInfo();
    Console.WriteLine( "How much would you like to bet?" );
    string howMuch = Console.ReadLine();
    int amount = 

}



