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
        Console.WriteLine(playingTable[0,0]);
        Console.WriteLine("1 |" + playingTable[0,0] + "|" + playingTable[0,1] + "|" + playingTable[0,2] + "|" + playingTable[0,3] + "|");
        Console.WriteLine("2 |" + playingTable[1,0] + "|" + playingTable[1,1] + "|" + playingTable[1,2] + "|" + playingTable[1,3] + "|");
        Console.WriteLine("3 |" + playingTable[2,0] + "|" + playingTable[2,1] + "|" + playingTable[2,2] + "|" + playingTable[2,3] + "|");
        Console.WriteLine("4 |" + playingTable[3,0] + "|" + playingTable[3,1] + "|" + playingTable[3,2] + "|" + playingTable[3,3] + "|");
        Console.WriteLine("X | 1 | 2 | 3 | 4 |");
    }

    static public void Main(String[] args) 
    { 
        playingTableGUI();

    } 
} 