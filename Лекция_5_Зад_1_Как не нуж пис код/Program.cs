// bool IsEven (int value)
// {
//     return value % 2 == 0;
// }

// var a = 10;
// Console.WriteLine(a.GetType());

// var data = new int[]{1, 2, 3, 4}

using System.Linq;
string text = "(1,2) (2,3) (4,5) (9,7)" //в строке написаны координаты точек фигуры
            .Replace("(", "") // убираем скобки
            .Replace(")", "") // убираем скобки
            ;
Console.WriteLine(text);            
// Задача. Увеличить координаты в 2 раза и передать пользователю
var data = text.Split(" ") // разделим текст на пробелы
            .Select(item => item.Split(',')) // делим элементы запятой
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // делаем выборку 
            //массива, где координаты равны тому-то
            .Where(e => e.x % 2 == 0) // проверка условия - берем пары, где первая 
            //координата четная
            .Select(point => (point.x * 10, point.y)) // из полученног набора первую координату
            //умножаем на 10
            .ToArray(); // превращаем в явный массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}
    /// 