Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayOfCub = new int[n];
for (int i = 1;  i < n + 1; i++ )
{
    arrayOfCub[i-1] = Convert.ToInt32(Math.Pow(i,3));
}
void ArrayPrinter(int[] a)
{
    Console.Write("This is your array: ");
    foreach (int i in arrayOfCub)
    {
        Console.Write($"[{i}] ");
    }
}    
ArrayPrinter(arrayOfCub);