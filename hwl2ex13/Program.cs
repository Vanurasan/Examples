string a = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
//Почему-то VS Code, в отличие от обычного VS не хочет, чтобы я записывал сразу в переменную, но такой костыль помог
// Program.cs(1,12): warning CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
//Program.cs(2,19): warning CS8602: Разыменование вероятной пустой ссылки.
//Не понимаю в чем проблема
if (a.Length < 3) {Console.WriteLine("Нет третьей цифры");}
else {Console.WriteLine(a[2]);};