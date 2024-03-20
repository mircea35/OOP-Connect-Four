using System;
using System.Collections.Generic;
using System.Globalization;
abstract class Player{
    public string playerName {get;set;}
    public int playerInt {get; set;}

    public Player(string name, int integer)
    {
        this.playerName = name;
        this.playerInt = integer;
    }

    public abstract string playerNumber();
}

class playerX : Player{
    public playerX(string name, int integer) : base(name, integer)
    {

    }

    public override string playerNumber()
    {
        return "x";
    }
}
    
class playerY : Player{
    public playerY(string name, int integer) : base(name, integer)
    {

    }

    public override string playerNumber()
    {
        return "y";
    }
}
  
internal class Program { 
    static string[,] playingTable = { 
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "},
    {" ", " ", " ", " ", " ", " ", " "}
    };

    static string player = "j";
    static int usrInput = 0;

    static void mainMenu(){

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
        Console.WriteLine($"Now playing: player {player}");
    } 

    static void pushToTable(){
        usrInput--;
        for(int i = 5; i >= 0; i--){
            if(playingTable[usrInput,i] == ""){
                playingTable[usrInput,i] = player;
            }
        }
    }

    public static int row = 7;
    public static int col = 6;

    public static bool CheckWinner(){
        //checking horisontally
        for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
                if (playingTable[i,j] == player && playingTable[i, j + 1] == player && playingTable[i, j + 2] == player && playingTable[i, j + 3] == player){
                    return true;
                }
            }
        }

        // Checking vertically
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (playingTable[i, j] == player && playingTable[i + 1, j] == player && playingTable[i + 2, j] == player && playingTable[i + 3, j] == player)
                    return true;
            }
        }

        // Checking diagonally (positive slope)
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 0; j < col - 3; j++)
            {
                if (playingTable[i, j] == player && playingTable[i + 1, j + 1] == player && playingTable[i + 2, j + 2] == player && playingTable[i + 3, j + 3] == player)
                    return true;
            }
        }

        // Checking diagonally (negative slope)
        for (int i = 0; i < row - 3; i++)
        {
            for (int j = 3; j < col; j++)
            {
                if (playingTable[i, j] == player && playingTable[i + 1, j - 1] == player && playingTable[i + 2, j - 2] == player && playingTable[i + 3, j - 3] == player)
                    return true;
            }
        }

        return false;
    }


    static public void Main(String[] args) 
    { 
        Console.WriteLine("___Connect Four Game___");
        Console.WriteLine("1 - Play");
        Console.WriteLine("2 - Exit");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option){
            case 1:
                playingTableGUI();
                usrInput = Convert.ToInt32(Console.ReadLine());
                if(usrInput < 1 || usrInput > 8)
                {
                    Console.WriteLine("Out of bounds");
                }
                break;
            case 2:
                break;
            default:
                break;
        }

    } 
} 