Console.WriteLine ("Введите число: ");

int a = int.Parse(Console.ReadLine()!); 
int m = 0;

while (a>1)
{
 if (a%2==0)
  {
    m = a;
   Console.Write ($"{m} ");
  }
else
    { m = 0;}
a-=1;
}
