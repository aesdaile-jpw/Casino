// See https://aka.ms/new-console-template for more information
using Casino;

double odds = 0.75;
Guy guy = new Guy() { Cash =100, Name = "The Player" };
Console.WriteLine( "Welcome to the casino, " + guy.Name + "! /n The odds today are " + odds );
while ( guy.Cash > 0 )
{
    guy.WriteMyInfo();
    Console.WriteLine( "How much would you like to bet? (enter nothing to leave)" );
    string? howMuch = Console.ReadLine();
    if ( howMuch == "" ) return;
    if ( int.TryParse(howMuch, out int amount ) )
    {
        int pot = guy.GiveCash( amount ) * 2;
        if (  pot > 0 )
        {
            if (Random.Shared.NextDouble() > odds )
            {
                int winnings = pot;
                Console.WriteLine( "You win!" );
                guy.ReceiveCash( winnings );
            }
            else
            {
                Console.WriteLine( "You lose!" );
            }
        }
    } 
    else
    { 
        Console.WriteLine( "Please enter a valid amount." );
    }



}
Console.WriteLine( "The house always wins!" );



