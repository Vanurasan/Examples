Console.Writeline("Введите переменную a");
int a = Convert.ToInt32(Console.ReadLine());
Console.Writeline("Введите переменную b");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b) {int max=a; int min = b;} else {int max = b; int min = a;};
 Console.Writeline("Максимальное:"+ max);
 Console.Writeline("Минимальное:"+ min);