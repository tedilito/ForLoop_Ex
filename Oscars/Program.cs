string nameOfNominee = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int countG = int.Parse(Console.ReadLine());
double finalPoints = 0;
double pointsGiven = 0;



for (int i = 1; i <= countG; i++)
{
    string NameG = Console.ReadLine();
    double pointsG = double.Parse(Console.ReadLine());
    int lenghtG = NameG.Length;

    pointsGiven = (lenghtG * pointsG) / 2 + points;
    points = pointsGiven;
    finalPoints = pointsGiven;


    if (finalPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {nameOfNominee} got a nominee for leading role with {finalPoints:f1}!");
        break;

    }


}
if (finalPoints < 1250.5)
{
    double neededPoits = 1250.5 - finalPoints;
    Console.WriteLine($"Sorry, {nameOfNominee} you need {neededPoits:f1} more!");
}