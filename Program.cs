string str;
Console.WriteLine("Enter a(beginning of the interval) to calculate the sum of all elements of the interval: ");

int a, b, sum;
sum = 0;
int j;
str = Console.ReadLine();
a = Convert.ToInt32(str);

Console.WriteLine("Input b(the end of the interval): ");
str = Console.ReadLine();
b = Convert.ToInt32(str);

if (a < b)
{
    for (j = Math.Abs(a - b - 1); j > 0; j--)
    {
        sum = sum + a;
        a++;
    }
    Console.WriteLine(sum);
}
else if (a > b)
{
    for(j = Math.Abs(b - a - 1); j > 0; j--)
    {
        sum = sum + b;
        b++;
    }
    Console.WriteLine(sum);
}
else if (a==b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Invalid input");
    Console.ReadKey();
}
