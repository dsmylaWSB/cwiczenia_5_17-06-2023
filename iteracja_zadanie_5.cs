int x = ZczytajLiczbe("Podaj liczbę naturalną x: ");
int n = ZczytajLiczbe("Podaj wykładnik n (całkowita nieujemna): ");

int wynik = Potega(x, n);
Console.WriteLine($"Wynik: {wynik}");

int oczekiwany = (int)Math.Pow(x, n);
Console.WriteLine($"Oczekiwany wynik: {oczekiwany}");

string wiadomosc = (wynik == oczekiwany) ? "Wyniki są zgodne." : "Wyniki są różne.";
Console.WriteLine(wiadomosc);



int ZczytajLiczbe(string wiadomosc)
{
    int liczba = 0;
    bool isValid = false;

    while (!isValid)
    {
        Console.Write(wiadomosc);
        isValid = int.TryParse(Console.ReadLine(), out liczba);

        if (!isValid)
        {
            Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę naturalną.");
        }
    }

    return liczba;
}

int Potega(int x, int n)
{
    if (n == 0)
        return 1;


    int wynik = x;
    int poprzedni = x;

    for (int i = 1; i < n; i++)
    {
        for (int j = 1; j < x; j++)
            wynik += poprzedni;


        poprzedni = wynik;
    }

    return wynik;
}
