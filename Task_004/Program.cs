Console.Write("Insert first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.Write("Max number is " + num1);
}
if(num2 > num1 && num2 > num3)
{
    Console.Write("Max number is " + num2);
}
if(num3 > num1 && num3 > num2)
{
    Console.Write("Max number is " + num3);
}