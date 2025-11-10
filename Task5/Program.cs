Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum += i;
}

Console.WriteLine("Sum from 1 to " + N + " is: " + sum);


int i = 1;

while (i <= 20)
{
    if (i % 4 == 0)
    {
        i++;
        continue; 
    }

    if (i == 15)
    {
        break;
    }

    Console.WriteLine(i);
    i++;
}


int[] numbers = { 2, 4, 6, 8, 10 };
int total = 0;

foreach (int num in numbers)
{
    total += num;
}

Console.WriteLine("Sum of array elements: " + total);
