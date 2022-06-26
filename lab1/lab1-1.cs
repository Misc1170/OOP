using System;

int n = 0;
int m = 0;
double resultX = 0;

Console.WriteLine(++n * ++m);

Console.WriteLine(m++ < n);

Console.WriteLine(n++ > m);

string numForX = Console.ReadLine();
int x = Convert.ToInt32(numForX);
resultX = x + (1 / (Math.Pow(x, 2) - x)) - 2;
Console.WriteLine(resultX);