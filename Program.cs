////Лаба 8 задание 1 Мирозниченко Е.А.

//using System;
//using System.Data;

//class Vector3D
//{
//    // Координаты вектора
//    public double x;
//    public double y;
//    public double z;

//    // Конструктор для инициализации координат
//    public Vector3D(double x, double y, double z)
//    {
//        this.x = x;
//        this.y = y;
//        this.z = z;
//    }

//    // Сложение векторов
//    public static Vector3D operator +(Vector3D v1, Vector3D v2)
//    {
//        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
//    }

//    // Вычитание векторов
//    public static Vector3D operator -(Vector3D v1, Vector3D v2)
//    {
//        return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
//    }

//    // Скалярное произведение векторов
//    public static double operator *(Vector3D v1, Vector3D v2)
//    {
//        return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
//    }

//    // Умножение вектора на скаляр
//    public static Vector3D operator *(Vector3D v, double scalar)
//    {
//        return new Vector3D(v.x * scalar, v.y * scalar, v.z * scalar);
//    }

//    // Сравнение векторов
//    public static bool operator ==(Vector3D v1, Vector3D v2)
//    {
//        return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
//    }

//    public static bool operator !=(Vector3D v1, Vector3D v2)
//    {
//        return !(v1 == v2);
//    }

//    // Вычисление длины вектора
//    public double Length()
//    {
//        return Math.Sqrt(x * x + y * y + z * z);
//    }

//    // Сравнение длины векторов
//    public static bool operator >(Vector3D v1, Vector3D v2)
//    {
//        return v1.Length() > v2.Length();
//    }

//    public static bool operator <(Vector3D v1, Vector3D v2)
//    {
//        return v1.Length() < v2.Length();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Пример использования класса Vector3D
//        // Ввод координат первого вектора с клавиатуры
//        Console.WriteLine("Введите координаты первого вектора:");
//        bool flag;
//        double n;
//        string s;
//        double x1, y1, z1;
//        Console.WriteLine("x: ");
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out x1);

//            if (!flag || x1 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод x1 =  ");
//            }
//        } while (!flag || x1 <= 0);

//        Console.Write("y: ");
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out y1);

//            if (!flag || y1 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод y1 = ");
//            }
//        } while (!flag || y1 <= 0);
//        Console.Write("z: ");
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out z1);

//            if (!flag || z1 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод z1 = ");
//            }
//        } while (!flag || z1 <= 0);

//        // Ввод координат второго вектора с клавиатуры
//        Console.WriteLine("\nВведите координаты второго вектора:");
//        Console.Write("x2: ");
//        double x2, y2, z2;
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out x2);

//            if (!flag || x2 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод x2 = ");
//            }
//        } while (!flag || x2 <= 0);
//        Console.Write("y2: ");
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out y2);

//            if (!flag || y2 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод y2 = ");
//            }
//        } while (!flag || y2 <= 0);
//        Console.Write("z2: ");
//        do
//        {
//            s = Console.ReadLine();
//            flag = double.TryParse(s, out z2);

//            if (!flag || z2 <= 0)
//            {
//                Console.Write("неверное значение, повторный ввод z2 = ");
//            }
//        } while (!flag || z2 <= 0);

//        // Создание объектов векторов
//        Vector3D vector1 = new(x1, y1, z1);
//        Vector3D vector2 = new(x2, y2, z2);


//        Vector3D sum = vector1 + vector2;
//        Console.WriteLine("Сумма векторов: " + sum.x + ", " + sum.y + ", " + sum.z);

//        Vector3D difference = vector1 - vector2;
//        Console.WriteLine("Разность векторов: " + difference.x + ", " + difference.y + ", " + difference.z);

//        double dotProduct = vector1 * vector2;
//        Console.WriteLine("Скалярное произведение векторов: " + dotProduct);

//        Vector3D scaledVector = vector1 * 2;
//        Console.WriteLine("Умножение вектора на скаляр: " + scaledVector.x + ", " + scaledVector.y + ", " + scaledVector.z);

//        bool areEqual = vector1 == vector2;
//        Console.WriteLine("Векторы равны: " + areEqual);

//        bool v1IsLonger = vector1 > vector2;
//        Console.WriteLine("Длина первого вектора больше длины второго: " + v1IsLonger);
//    }
//}

















//Лаба 8 задание 2 Мирозниченко Е.А.


using System;

class Bankomat
{
    private readonly int id;
    private int[] banknotesCount;
    private int minWithdrawal;
    private int maxWithdrawal;

    public Bankomat(int id, int[] banknotesCount, int minWithdrawal, int maxWithdrawal)
    {
        this.id = id;
        this.banknotesCount = banknotesCount;
        this.minWithdrawal = minWithdrawal;
        this.maxWithdrawal = maxWithdrawal;
    }

    // Метод для загрузки купюр в банкомат
    public void LoadBanknotes(int[] banknotesToAdd)
    {
        if (banknotesToAdd.Length > banknotesCount.Length)
        {
            Console.WriteLine("Ошибка: неверное количество номиналов купюр.");
            return;
        }

        for (int i = 0; i < banknotesToAdd.Length; i++)
        {
            banknotesCount[i] += banknotesToAdd[i] * 10;
        }

        Console.WriteLine("Купюры успешно добавлены в банкомат.");
    }

    // Метод для снятия денег
    public void WithdrawMoney(int amount)
    {
        if (amount < minWithdrawal || amount > maxWithdrawal)
        {
            Console.WriteLine("Ошибка: сумма для снятия не соответствует допустимому диапазону.");
            return;
        }

        int remainingAmount = amount;

        for (int i = banknotesCount.Length - 1; i >= 0; i--)
        {
            int count = Math.Min(remainingAmount / banknotesCount[i], banknotesCount[i]);
            remainingAmount -= count * banknotesCount[i];
            banknotesCount[i] -= count;

            if (remainingAmount == 0)
            {
                Console.WriteLine($"Сумма {amount} успешно снята с банкомата.");
                return;
            }
        }

        Console.WriteLine("Ошибка: невозможно выдать указанную сумму.");
    }

    // Метод для отображения оставшейся суммы в банкомате
    public void DisplayRemainingAmount()
    {
        int totalAmount = 0;
        for (int i = 0; i < banknotesCount.Length; i++)
        {
            totalAmount += banknotesCount[i] * 10;
        }

        Console.WriteLine($"Оставшаяся сумма в банкомате: {totalAmount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] banknotesCount = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }; // Начальное количество купюр каждого номинала
        int minWithdrawal = 10; // Минимальная сумма для снятия
        int maxWithdrawal = 1000; // Максимальная сумма для снятия

        Bankomat bankomat = new Bankomat(123456, banknotesCount, minWithdrawal, maxWithdrawal);

        // Пример использования методов
        bankomat.DisplayRemainingAmount();

        // Пополнение или снятие средств
        Console.WriteLine("Введите сумму для пополнения (+) или снятия (-) средств:");
        int transactionAmount = int.Parse(Console.ReadLine());

        if (transactionAmount > 0)
        {
            bankomat.LoadBanknotes(new int[] { transactionAmount / 1000, (transactionAmount % 1000) / 100, (transactionAmount % 100) / 10 });
        }
        else if (transactionAmount < 0)
        {
            bankomat.WithdrawMoney(-transactionAmount);
        }

        bankomat.DisplayRemainingAmount();
    }
}
