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
                Console.WriteLine("Player {0} Has Won.", (player % 2) + 1);
            }
            {
            Console.WriteLine("Draw.");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
        Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {
        
        }
    }
}
