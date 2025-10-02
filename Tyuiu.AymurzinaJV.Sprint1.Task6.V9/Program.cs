using Tyuiu.AymurzinaJV.Sprint1.Task6.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
Console.WriteLine("* Напечатать все слова, перенеся их последнюю букву в начало.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

string x;

Console.WriteLine("Введите текст:");
x = Console.ReadLine();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.MoveLetterToStart(x));

Console.ReadLine();