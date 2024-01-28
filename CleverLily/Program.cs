int age = int.Parse(Console.ReadLine());
double priceWash = double.Parse(Console.ReadLine());
double priceToy = double.Parse(Console.ReadLine());

int Toys = 0;
double totalToys = 0;
double money = 0;
double totalMoney = 0;
double currentMoney = 0;
double moneyBrother = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
         money++;
        currentMoney = money * 10;
        moneyBrother += 1;
        totalMoney += currentMoney;

    }
    else
    {
        Toys++;
       
    }

}
totalToys = Toys * priceToy;

double moneySaved = totalToys + totalMoney - moneyBrother;

if (moneySaved >= priceWash)
{
    double moneyLeft = moneySaved - priceWash;
    Console.WriteLine($"Yes! {moneyLeft:f2}");
}
else
{
    double moneyNeeded = priceWash - moneySaved;
    Console.WriteLine($"No! {moneyNeeded:f2}");
}