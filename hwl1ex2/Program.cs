Console.WriteLine("Введите переменную a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b");
int b = Convert.ToInt32(Console.ReadLine());
int max=0;
int min=0;
if (a>b) {max=a; min = b;} else {max = b; min = a;};
 Console.WriteLine("Максимальное:"+ max);
 Console.WriteLine("Минимальное:"+ min);