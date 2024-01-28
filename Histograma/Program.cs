int nCount = int.Parse(Console.ReadLine());
double numCount = 0;
double numCount2 = 0;
double numCount3 = 0;
double numCount4 = 0;
double numCount5 = 0;

for (int i = 0; i < nCount; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200)
    {
        numCount++;
    }
    else if (num >= 200 && num <= 399)
    {
        numCount2++;
    }
    else if (num >= 400 && num <= 599)
    {
        numCount3++;
    }
    else if (num >= 600 && num <= 799)
    {
        numCount4++;
    }
    else if (num >= 800)
    {
        numCount5++;
    }

}

double p1 = (numCount / nCount) * 100;
double p2 = (numCount2 / nCount) * 100;
double p3 = (numCount3 / nCount) * 100;
double p4 = (numCount4 / nCount) * 100;
double p5 = (numCount5 / nCount) * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");