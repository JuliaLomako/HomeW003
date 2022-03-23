//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

int numberFive 



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

/*
double findDistans(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDis = x2 - x1;
    double yDis = y2 - y1;
    double zDis = z2 - z1;
    return Math.Sqrt(Math.Pow(xDis,2) + Math.Pow(yDis,2) + Math.Pow(zDis,2));
}

double xA, yA, zA, xB, yB, zB;
double distanse;

Console.Write("Input x of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z of point A");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x of point B: "); 
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z jf point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(findDistans(xA, yA, zA, xB, yB, zB));



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

*/

double CubN(double n)
{
    double n = 1;
    double n1 = Math.Pow(n,3); 
    
    if (n1 == n)
    Console.WriteLine("stop");
    else
    {
        Console.WriteLine();
        n1++;   
    }
    return n2;
}

Console.Write("Input a number: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CubN(numA));



