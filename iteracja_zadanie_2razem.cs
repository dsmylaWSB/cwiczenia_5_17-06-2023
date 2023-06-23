// Wersja, w której poprawność losowania sprawdzana jest po losowaniu

const int n = 10;
Random random = new Random();
int licznikLosowan = 0;
int iloscLiczbDoWylosowania = n;

for (int iloscLiczbWylosowanych = 0; iloscLiczbWylosowanych < iloscLiczbDoWylosowania; iloscLiczbWylosowanych++)
{
    int wylosowanaLiczba;
    do
    {
        wylosowanaLiczba = random.Next(-8, 9);
        licznikLosowan++;
    } while (wylosowanaLiczba % 2 != 0);

    Console.Write(wylosowanaLiczba);

    if (iloscLiczbWylosowanych < iloscLiczbDoWylosowania - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("\n\nLicznik liczb wylosowanych: " + licznikLosowan + "\n\n\n");


// Wersja, w której od razu losowana jest liczba parzysta


for (int iloscLiczbWylosowanych = 0; iloscLiczbWylosowanych < iloscLiczbDoWylosowania; iloscLiczbWylosowanych++)
{
    int wylosowanaLiczba;

    wylosowanaLiczba = random.Next(-4, 5);
    wylosowanaLiczba *= 2;
    licznikLosowan++;

    Console.Write(wylosowanaLiczba);

    if (iloscLiczbWylosowanych < iloscLiczbDoWylosowania - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("\n\nLicznik liczb wylosowanych: " + licznikLosowan);