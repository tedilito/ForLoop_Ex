int countT = int.Parse(Console.ReadLine());
int startPoins = int.Parse(Console.ReadLine());
double bonusPoints = 0;
double counterWon = 0;

for (int i = 0; i < countT; i++)
{
    string res = Console.ReadLine();

	switch (res)
	{
		case "W":
            counterWon++;
			bonusPoints += 2000;
			break;

        case "F":
            bonusPoints += 1200;
            break;

        case "SF":
            bonusPoints += 720;
            break;

	}
}

double totalPoints = startPoins + bonusPoints;

double mid = Math.Floor((bonusPoints / countT));
double percentWon =(counterWon / countT) * 100;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {mid}");
Console.WriteLine($"{percentWon:f2}%");