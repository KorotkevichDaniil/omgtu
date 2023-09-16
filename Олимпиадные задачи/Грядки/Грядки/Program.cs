int[] k = new int[] { 1, 2, 3, 20 };
int l = 7;
int n = 5;
int m = 10;
int sum = 0;

for(int i = 0; i < k.Length; i++)
{
    for(int j = 0; j < k[i]; j++)
    {
        sum += 2 * l + 2 * (m + n) + m * j * 2;
    }
    Console.WriteLine("При k = " + k[i]);
    Console.WriteLine("Путь равен " + sum);
    sum = 0;
}

Console.ReadLine();
