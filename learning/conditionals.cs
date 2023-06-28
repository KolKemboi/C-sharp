
using System;

public class Conditionals
{
    public static void Main(string[] args)
    {
        bool onStart = true;
        bool checkGameState = false;
        bool playerIsCaptured = false;
        bool playerHealthy = true;
        
        if (onStart){
            checkGameState = true;
        }
        if (checkGameState){
            Console.WriteLine("Game Still Active");
            if (!playerIsCaptured){
                Console.WriteLine("The Player is Captured");
                checkGameState = false;
            }
            if (playerHealthy){
                Console.WriteLine("Player still Healthy");
            }
        }else {
            Console.WriteLine("The Game is inactive");
        }
       Console.WriteLine(checkGameState); 
        
    }
}