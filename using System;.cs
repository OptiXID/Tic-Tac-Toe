using Systen;
using Systen.Threading;
namescpace Tic_Tac_Toe
{
    class program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', }
        static int player = 1;
        static int choice;

        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                console.Clear();
                console.WriteLine("Player1:X and Player2:O");
                console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    console.WriteLine("Player 2 Chance");
                }
                else
                {
                    console.WriteLine("Player 1 Chance");
                }
                console.WriteLine("\n");
                Board();
                choice = int.Parse(console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    

                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    console.WriteLine("Sorry the row {0} already marked with {1}", choice, arr[choice];)
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            console.Clear();
            Board();
            if (flag == 1)
            {
                
            }
        } 
    }
}