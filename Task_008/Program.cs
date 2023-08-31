Console.Write("Insert number bigger then 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if(N < 2) 
Console.Write("Incorrect number!");

while (count <= N)
{
    Console.Write(count + ", ");
    count = count + 2;
}