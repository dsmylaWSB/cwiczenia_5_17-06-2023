int n = int.Parse(Console.ReadLine());
int licznik = 0;
int i = 2;

while (licznik < n)
{
    bool czyLiczbaPierwsza = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            czyLiczbaPierwsza = false;
        }
    }
    if (czyLiczbaPierwsza)
    {
        licznik++;
        Console.Write(i + ", ");
    }
    i++;
}