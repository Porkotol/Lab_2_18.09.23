
class Square
{
    private double st;
    public double St //// st != St

    {
        get { return st; }
        set { st = value; } //// присвоення значення сторонi
    }

    public bool Correct()
    {
        return st > 0; ////чи може існувати такий об'єкт. Квадрат існує, якщо його сторона позитивна.
    }

    public double Area()
    {
        double ar = st * st;   /////метод обчислює площу квадрата.
        return ar;
    }

    public double Perimetr()
    {
        double p = 4 * st;     /////метод обчислює периметр квадрата.
        return p;
    }
    
    public void Print()
    {
        Console.WriteLine("Сторона Квадрата = {0}" , st); /////Метод без параметрів Print, що виводить на екран значення поля.
    }
}
class Program
{
    static void Main(string[] args)
    {
        double st;
        try
        {
            Square square = new Square();  ///Створити об'єкт за допомогою конструктора за замовчуванням
            Console.WriteLine("Cторона квадрата = "); st = Convert.ToDouble(Console.ReadLine());
            square.St = st; ////Присвоїти значення полю за допомогою властивості
            square.Print();  ///Вивести значення поля на екран за допомогою методу Print;

            if (square.Correct())
            {
                double a = square.Area();
                double p = square.Perimetr();
                Console.WriteLine("Площа = {0} Периметр = {1} ", a, p);
            }
            else Console.WriteLine("Квадрат не існує");
        }
        catch
        {
            Console.WriteLine("Помилка!!!");
        }
        Console.ReadKey();
    }
}