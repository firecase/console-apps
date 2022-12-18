Random random = new Random();
string input;
int antwort;
int proof = 0;
int lives = 3;

// create array skeleton
int[] array = new int[8];

// initialize array
for (int a = 0; a < array.Length; a++)
{
    array[a] = random.Next(10);
}

// save solutions
int losung1 = array[0] * array[1];
int losung2 = array[2] * array[3];
int losung3 = array[4] * array[5];
int losung4 = array[6] * array[7];

// the quiz
Console.WriteLine("MATH QUIZ");
Console.WriteLine("---------");
Console.WriteLine("This is a math quiz. You only have three lives. Count carefully.");

while (proof == 0)
{
    Console.Write($"{array[0]} * {array[1]} = ");

    input = Console.ReadLine()!;

    if (input == null || input == "")
    {
        Console.WriteLine();
        Console.WriteLine("------------------");
        Console.WriteLine("| TYPE SOMETHING |");
        Console.WriteLine("------------------");
        Console.WriteLine();
    } else {
        antwort = Int32.Parse(input);

        if (antwort == losung1)
        {
            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("| TRUE |");
            Console.WriteLine("--------");

            proof++;
        }
        else
        {
            lives--;

            if (lives == 0)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine("| YOU LOST |");
                Console.WriteLine("------------");
                Console.WriteLine();

                Environment.Exit(0);
            }

            if (lives == 1)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVE LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            } else
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVES LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
        }
    }
}

proof = 0;

Console.WriteLine();

while (proof == 0)
{
    Console.Write($"{array[2]} * {array[3]} = ");

    input = Console.ReadLine()!;

    if (input == null || input == "")
    {
        Console.WriteLine();
        Console.WriteLine("------------------");
        Console.WriteLine("| TYPE SOMETHING |");
        Console.WriteLine("------------------");
        Console.WriteLine();
    }
    else
    {
        antwort = Int32.Parse(input);

        if (antwort == losung2)
        {
            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("| TRUE |");
            Console.WriteLine("--------");

            proof++;
        }
        else
        {
            lives--;

            if (lives == 0)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine("| YOU LOST |");
                Console.WriteLine("------------");
                Console.WriteLine();

                Environment.Exit(0);
            }

            if (lives == 1)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVE LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVES LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
        }
    }
}

proof = 0;

Console.WriteLine();

while (proof == 0)
{
    Console.Write($"{array[4]} * {array[5]} = ");

    input = Console.ReadLine()!;

    if (input == null || input == "")
    {
        Console.WriteLine();
        Console.WriteLine("------------------");
        Console.WriteLine("| TYPE SOMETHING |");
        Console.WriteLine("------------------");
        Console.WriteLine();
    }
    else
    {
        antwort = Int32.Parse(input);

        if (antwort == losung3)
        {
            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("| TRUE |");
            Console.WriteLine("--------");

            proof++;
        }
        else
        {
            lives--;

            if (lives == 0)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine("| YOU LOST |");
                Console.WriteLine("------------");
                Console.WriteLine();

                Environment.Exit(0);
            }

            if (lives == 1)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVE LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVES LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
        }
    }
}

proof = 0;

Console.WriteLine();

while (proof == 0)
{
    Console.Write($"{array[6]} * {array[7]} = ");

    input = Console.ReadLine()!;

    if (input == null || input == "")
    {
        Console.WriteLine();
        Console.WriteLine("------------------");
        Console.WriteLine("| TYPE SOMETHING |");
        Console.WriteLine("------------------");
        Console.WriteLine();
    }
    else
    {
        antwort = Int32.Parse(input);

        if (antwort == losung4)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| TRUE, YOU PASSED THE TEST |");
            Console.WriteLine("-----------------------------");

            proof++;
        }
        else
        {
            lives--;

            if (lives == 0)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine("| YOU LOST |");
                Console.WriteLine("------------");
                Console.WriteLine();

                Environment.Exit(0);
            }

            if (lives == 1)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVE LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine($"| FALSE, YOU HAVE {lives} LIVES LEFT |");
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
        }
    }
}