Console.WriteLine ("Введите 2 числа: ");
int a = 0;
int b = 0;

string numberone = Console.ReadLine (); 
string numbertwo = Console.ReadLine (); 

a = int.Parse(numberone);
b = int.Parse(numbertwo);

if (a > b)
{
    Console.Write ($"max = {a}, min = {b} ");
}
else 
{
    Console.Write ($"max = {b}, min = {a}");
}