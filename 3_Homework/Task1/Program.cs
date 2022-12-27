Console.WriteLine("Enter a five-digit number");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
for (int i = num1 ; i > 0 ; i/= 10)
{
    num2 = num2 * 10 + (i % 10);
}
if (num1 == num2)
{
    Console.WriteLine("Correct");
}
else
    Console.WriteLine("Wrong");