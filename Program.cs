using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
abstract class Player{
    public string playerName {get;set;}
    public string playerChar {get; set;}

    public Player(string name, string userChar)
    {
        this.playerName = name;
        this.playerChar = userChar;
    }

    public abstract string playerNumber();
}

class playerX : Player{
    public playerX(string name, string userChar) : base(name, userChar)
    {

    }

    public override string playerNumber()
    {
        return "x";
    }
}
    
class playerY : Player{
    public playerY(string name, string userChar) : base(name, userChar)
    {

    }

    public override string playerNumber()
    {
        return "y";
    }
}
  
internal class Program { 
    static int userInput = 0;
    static int turnCounter = 0;
    public static int row = 7;
    public static int col = 6;
    static int option = 0;
    static bool hasWon = false;

    static string[,] playingTable = { 
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "}
    };

    static void definingPlayers(){
        for(turnCounter = 0; turnCounter < 2; turnCounter++){
            Console.WriteLine("Player name: ");
            switch(turnCounter){
                case 0:
                    Player playerOne = new playerX(tempName, tempChar);
                    break;
                default:
                    Player playerTwo = new playerY(tempName, tempChar);
                    break;
            }
        }
    }

    static void playingTableGUI()
    {
        Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |");
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 7; j++){
                Console.Write("| " + playingTable[i,j] + " " );
            }
            Console.WriteLine("|");
        }
        Console.WriteLine($"Now playing: player {playingUser.playerName}");
    } 

    static void pushToTable()
    {
        for(int i = 0; i <= 5; i++){
            if(playingTable[5 - i, option] == " "){
                playingTable[5 - i, option] = playingUser.playerNumber();
                break;
            }
            else{
                Console.WriteLine("Cannot put more there! Try another one.");
            }
        }
    }

//This function checks the playingTable array for a 4-in-a-row character. If a line of identical 4 characters is detected, the user which
//has that character will be declared the winner of the game. The game will also stop once that is done.
    public static bool CheckWinner(){
        //checking horisontally
        for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
                if (playingTable[i,j] == playingUser.playerChar && playingTable[i, j + 1] == playingUser.playerChar && playingTable[i, j + 2] == playingUser.playerChar && playingTable[i, j + 3] == playingUser.playerChar){
                    return true;
                }
            }
        }

        // Checking vertically
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (playingTable[i, j] == playingUser.playerChar && playingTable[i + 1, j] == playingUser.playerChar && playingTable[i + 2, j] == playingUser.playerChar && playingTable[i + 3, j] == playingUser.playerChar)
                    return true;
            }
        }

        // Checking diagonally (positive slope)
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 0; j < col - 3; j++)
            {
                if (playingTable[i, j] == playingUser.playerChar && playingTable[i + 1, j + 1] == playingUser.playerChar && playingTable[i + 2, j + 2] == playingUser.playerChar && playingTable[i + 3, j + 3] == playingUser.playerChar)
                    return true;
            }
        }

        // Checking diagonally (negative slope)
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 3; j < col; j++)
            {
                if (playingTable[i, j] == playingUser.playerChar && playingTable[i + 1, j - 1] == playingUser.playerChar && playingTable[i + 2, j - 2] == playingUser.playerChar && playingTable[i + 3, j - 3] == playingUser.playerChar)
                    return true;
            }
        }

        return false;
    }

    public static string tempName = "", tempChar = "";
    public static int tempInt = 0;

    static Player playingUser;
    static public void Main(String[] args) 
    { 

        
        List<string> names = new List<string>();

        Console.WriteLine("___Connect Four Game___");
        Console.WriteLine("1 - Play");
        Console.WriteLine("2 - Exit");

        string userInput = Console.ReadLine();

        if(int.TryParse(userInput, out option) && option > 0 && option < 3){
            switch(option){
                case 1:

                    for(turnCounter = 0; turnCounter < 2; turnCounter++){
                        Console.WriteLine("Player name: ");
                        userInput = Console.ReadLine();
                        names.Add(userInput);
                    }
                    
                    Player playerOne = new playerX(names[0], tempChar);
                    Player playerTwo = new playerY(names[1], tempChar);

                    turnCounter = 0;

                    switch(turnCounter){
                        case 0:
                            playingUser = playerOne;
                            break;

                        default:
                            playingUser = playerTwo;
                            break;
                    }

                    while(hasWon == false){
                        playingTableGUI();

                        userInput = Console.ReadLine();

                        if(int.TryParse(userInput, out option) && option < 1 || option >= 8)
                        {
                            Console.WriteLine("Out of bounds");
                        }
                        else{
                            option--;
                            pushToTable();
                        }

                    }
                    break;

                default:
                    Console.WriteLine("See you soon!");
                    break;
            }
        }



    } 
} 