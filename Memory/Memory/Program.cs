Random random = new Random();

int[,] board = new int[4, 4];

for (int y = 0; y <= 3; y++)
{
    for (int x = 0; x <= 3; x++)
    {
        board[y,x] = random.Next(10);
    }
}

foreach (int i in board)
{
    Console.WriteLine(i);
}