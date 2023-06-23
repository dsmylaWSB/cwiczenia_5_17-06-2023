
int rozmiar = wczytanieRozmiaru(); // Wczytanie rozmiaru rombu od użytkownika

if (rozmiar > 0)
    narysujRomb(rozmiar);
else
    Console.WriteLine("Nieprawidłowy rozmiar rombu. Program zostanie zakończony.");



int wczytanieRozmiaru()
{
    const int maxProby = 3;
    int proby = 0;
    int rozmiar = 0;

    while (proby < maxProby)
    {
        Console.Write("Podaj nieparzysty rozmiar rombu (>=3): ");
        if (int.TryParse(Console.ReadLine(), out rozmiar) && rozmiar >= 3 && rozmiar % 2 != 0)
        {
            return rozmiar;
        }
        else
        {
            proby++;
            Console.WriteLine("Nieprawidłowa wartość. Pozostało prób: " + (maxProby - proby));
        }
    }

    return -1; // Zwracamy -1, jeśli nie udało się wczytać prawidłowej wartości po 3 próbach
}

void narysujRomb(int rozmiar)
{
    Random random = new Random();
    char obramowanie = GetRandomChar(random, new char[] { '#', '@', '|', '*' });
    char wypelnienie = GetRandomChar(random, new char[] { '.', ':', '-', '+' });

    int spacje = rozmiar / 2;
    int znaki = 1;

    for (int i = 0; i < rozmiar; i++)
    {
        for (int j = 0; j < spacje; j++)
            Console.Write(" ");

        for (int j = 0; j < znaki; j++)
        {
            if (j == 0 || j == znaki - 1 || i == 0 || i == rozmiar - 1)
            {
                Console.Write(obramowanie);
            }
            else
            {
                Console.Write(wypelnienie);
            }
        }

        for (int j = 0; j < spacje; j++)
            Console.Write(" ");

        Console.WriteLine();

        if (i < rozmiar / 2)
        {
            spacje--;
            znaki += 2;
        }
        else
        {
            spacje++;
            znaki -= 2;
        }
    }
}

char GetRandomChar(Random random, char[] znaki)
{
    int index = random.Next(znaki.Length);
    return znaki[index];
}
