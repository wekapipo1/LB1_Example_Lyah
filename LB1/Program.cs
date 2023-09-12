using System;

public class Triangle
{
    double a, b, c; //поля
    public Triangle() //конструктор без параметрів
    { }
    //конструктор з 3 параметрами
    public Triangle(double x, double y, double z)
    { a = x; b = y; c = z; }

    //метод, який виводе на екран поля
    public void Print()
    { Console.WriteLine("a={0} b={1} c={2}",a,b,c); }

    //метод, який обчислює париметр
    public double Perimetr()
    {
        double p = a + b + c;
        return p;
    }

    //метод, який обчислює площу
    public double Sqr()
    {
        double p = this.Perimetr()/2;
        double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        return s;
    }

    //метод, який провіряє існування такого об'єкта
    public bool Correct()
    {
        bool p = false;
        if (a>0 && b>0 && c>0 && a<b+c && b<a+c && c<a+b) p = true;
        return p;
    }
}
 class Program
{
    static void Main(string[] args)
    {
        double x, y, z;
        try
        {
            //вводимо сторони трикутника
            Console.Write("x="); x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y="); y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z="); z = Convert.ToDouble(Console.ReadLine());
            //створення об'єкту
            Triangle t = new Triangle(x, y, z);
            //
            t.Print();
            //перевірка існування об'єкта
            if (t.Correct()) //об'єкт існує
            {
                //застосування методів
                double p = t.Perimetr();
                double s = t.Sqr();
                //виводимо результат
                Console.WriteLine("P={0} S={1:F3}", p, s);
            }
            //об'єкт не уснує
            else Console.WriteLine("Такого трикутника не iснує");

        }
        catch
        {
            //інші можливі виключення
            Console.WriteLine("Помилка!!!");
        }
        Console.ReadKey();
    }
}