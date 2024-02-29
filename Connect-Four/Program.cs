using System;
class Program { 

    static int[,] playingTable = { 
    {3, 0, 0, 0, 1, 2, 7},
    {3, 0, 0, 0, 1, 2, 6},
    {3, 0, 0, 0, 1, 2, 4},
    {3, 0, 0, 0, 1, 2, 5},
    {3, 0, 0, 0, 1, 2, 8},
    {3, 0, 0, 0, 1, 2, 9}
    };

    static int playerNo = 0;
    static int usrInput = 0;

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
        Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |");
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 7; j++){
                Console.Write("| " + playingTable[i,j] + " " );
            }
            Console.WriteLine("|");
        }
    } 

    static void pushToTable(){
        usrInput--;
        for(int i = 5; i >= 0; i--){
            if(playingTable[usrInput,i] == 0){
                playingTable[usrInput,i] = playerNo;
            }
        }
    }
    static public void Main(String[] args) 
    { 
        playingTableGUI();

    } 
} 