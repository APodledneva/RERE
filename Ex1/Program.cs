Console.WriteLine ("Введите 2 числа: ");
string numberone = Console.ReadLine (); 
string numbertwo = Console.ReadLine (); 

int a = int.Parse(numberone);
int b = int.Parse(numbertwo);

if (a > b)
    Console.Write ($"max = {a}, min = {b} ");
else 
    Console.Write ($"max = {b}, min = {a}");