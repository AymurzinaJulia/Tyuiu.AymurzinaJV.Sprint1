using Tyuiu.AymurzinaJV.Sprint1.Task7.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("                    y");
Console.WriteLine("z = x * ln x + -----------");
Console.WriteLine("              cos x - x / 3");


double x;
double y;

Console.WriteLine("Введите x:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();
