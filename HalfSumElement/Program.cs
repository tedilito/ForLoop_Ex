

int numCount = int.Parse(Console.ReadLine());
int maxNum = int.MinValue;
int sum = 0;

for (int i = 0; i < numCount; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > maxNum)
    {
        maxNum = num;

    }
    sum += num;


}
sum -= maxNum;
if (maxNum == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
}