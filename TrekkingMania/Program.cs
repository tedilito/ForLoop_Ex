int countGr = int.Parse(Console.ReadLine());
double countM = 0;
double countMo = 0;
double countK = 0;
double countK2 = 0;
double countEve = 0;
double totalGroup = 0;
for (int i = 0; i < countGr; i++)
{
    int countPeople = int.Parse(Console.ReadLine());

    if (countPeople <= 5)
    {
        //Musala
         countM += countPeople;

    }
    else if (countPeople <= 12)
    {
        //Monblan
        countMo += countPeople;

    }
    else if (countPeople <= 25)
    {
        //Kilimandjaro
        countK += countPeople;
    }
    else if (countPeople <= 40)
    {
        //k2
        countK2 += countPeople;
    }
    else if (countPeople >= 41)
    {
        //Everest
        countEve += countPeople;
    }
    totalGroup = countM + countMo + countK + countK2 + countEve;

}

double percentageMu = countM / totalGroup * 100;
double percentageMo = countMo / totalGroup * 100;
double percentageK =countK / totalGroup * 100;
double percentageK2 = countK2 / totalGroup * 100;
double percentageEve = countEve / totalGroup * 100;

Console.WriteLine($"{percentageMu:f2}%");
Console.WriteLine($"{percentageMo:f2}%");
Console.WriteLine($"{percentageK:f2}%");
Console.WriteLine($"{percentageK2:f2}%");
Console.WriteLine($"{percentageEve:f2}%");