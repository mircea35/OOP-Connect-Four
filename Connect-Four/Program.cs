using System;
class Program { 

    static int[,] playingTable = { 
    {3, 0, 0, 0},
    {3, 0, 0, 0},
    {3, 0, 0, 0},
    {3, 0, 0, 0}
    };

    int playerNo = 0;

    static void mainMenu(){
        Console.WriteLine("===Connect Four Game===");
        Console.WriteLine("1 - Play");
        Console.WriteLine("2 - Exit");
        int option = 0;
        switch(option){
            case 1:
                break;
            case 2:
                break;
            default:
                break;
        }
    }

    static void playingTableGUI()
    {
        Console.WriteLine("1 |", playingTable[0,0], "|" , playingTable[0,1], "|" , playingTable[0,2], "|", playingTable[0,3], "|");
        Console.WriteLine("2 |", playingTable[0,0], "|" , playingTable[0,1], "|" , playingTable[0,2], "|", playingTable[0,3], "|");
        Console.WriteLine("3 |", playingTable[0,0], "|" , playingTable[0,1], "|" , playingTable[0,2], "|", playingTable[0,3], "|");
        Console.WriteLine("4 |", playingTable[0,0], "|" , playingTable[0,1], "|" , playingTable[0,2], "|", playingTable[0,3], "|");
        Console.WriteLine("X | 1 | 2 | 3 | 4 |");
    }

    static public void Main(String[] args) 
    { 
        playingTableGUI();

    } 
} 