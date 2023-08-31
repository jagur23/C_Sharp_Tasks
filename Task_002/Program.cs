Console.Write("Insert first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("Max = " + num1);
}
else
{
    Console.Write("Max = " + num2);
}