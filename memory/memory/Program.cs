Random random = new Random();
int[,] board = new int[4, 4];

// create print method
void printOpenBoard()
{
    for (int y = 0; y <= 3; y++)
    {
        for (int x = 0; x <= 3; x++)
        {
            if (x == 3)
            {
                Console.WriteLine(board[x, y] + " ");
            }
            else
            {
                Console.Write(board[x, y] + " ");
            }
        }
    }
}

// initialize array
for (int y = 0; y <= 3; y++)
{
    for (int x = 0; x <= 3; x++)
    {
        board[y, x] = random.Next(7);
    }
}

printOpenBoard();