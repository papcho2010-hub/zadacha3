



using System.Drawing;
using zadacha3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// -------------------------------------------------
// 1. Демонстрация на Time
// -------------------------------------------------

Console.WriteLine("========== TIME ==========");

Time time1 = new Time();
Time time2 = new Time(9, 5, 7);

Console.Write("Време 1: ");
time1.DisplayTime();

Console.Write("Време 2: ");
time2.DisplayTime();


// -------------------------------------------------
// 2. Демонстрация на Rectangle и Circle
// -------------------------------------------------

Console.WriteLine();
Console.WriteLine("===== RECTANGLE & CIRCLE =====");

Rectangle rectangle1 = new Rectangle();
Rectangle rectangle2 = new Rectangle(5, 10);

Console.WriteLine(
    "Площ на правоъгълник 1: " +
    rectangle1.Area()
);

Console.WriteLine(
    "Площ на правоъгълник 2: " +
    rectangle2.Area()
);


Circle circle1 = new Circle();
Circle circle2 = new Circle(5);

Console.WriteLine(
    "Площ на кръг 1: " +
    circle1.Area()
);

Console.WriteLine(
    "Площ на кръг 2: " +
    circle2.Area()
);


// -------------------------------------------------
// 3. Демонстрация на Student
// -------------------------------------------------

Console.WriteLine();
Console.WriteLine("========== STUDENT ==========");

Student student1 = new Student();

Student student2 = new Student(
    "Петър Петров",
    12345
);

Student student3 = new Student(
    "Георги Георгиев",
    54321,
    "Компютърни науки",
    "2 курс"
);

Console.WriteLine("\nСтудент 1:");
student1.DisplayInfo();

Console.WriteLine("\nСтудент 2:");
student2.DisplayInfo();

Console.WriteLine("\nСтудент 3:");
student3.DisplayInfo();


// -------------------------------------------------
// 4. Демонстрация на валидация
// -------------------------------------------------

Console.WriteLine();
Console.WriteLine("========== VALIDATION ==========");

try
{
    Time invalidTime = new Time(-1, 20, 30);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Грешка: " + ex.Message);
}

try
{
    Rectangle invalidRectangle = new Rectangle(0, 5);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Грешка: " + ex.Message);
}

try
{
    Circle invalidCircle = new Circle(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Грешка: " + ex.Message);
}

try
{
    Student invalidStudent = new Student(
        "Ив",
        0,
        "IT",
        "2"
    );
}
catch (ArgumentException ex)
{
    Console.WriteLine("Грешка: " + ex.Message);
}

Console.WriteLine();
Console.WriteLine("Натиснете клавиш за край...");
Console.ReadKey();
        
