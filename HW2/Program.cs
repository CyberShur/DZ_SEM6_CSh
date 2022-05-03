/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double b1 = Coordinate("b1", "первой прямой");
double k1 = Coordinate("k1", "первой прямой");
double b2 = Coordinate("b2", "второй прямой");
double k2 = Coordinate("k2", "второй прямой");

Console.WriteLine($"Введённые координаты прямых: b1-k1 - ({b1}, {k1}) и b2-k2 - ({b2}, {k2})");

double X0 = (b2 - b1)/(k1 - k2); // находим абциссу точки пересечения прировняв оба уровнения: k1 * x + b1 = k2 * x + b2.
double Y0 = k1 * X0 + b1; // подставляем Х0 в одно из уравнений и находим точку пересечения по оси Y. В данном случае в первое. 

Console.Write($"Прямые пересекаются в точке - ({X0}; {Y0})");

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: "); 
    return Convert.ToInt32(Console.ReadLine());
}

//y = k1 * x + b1 
//y = k2 * x + b2
