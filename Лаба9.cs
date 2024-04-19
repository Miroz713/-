//Лаба 9 вариант 2 Мирозниченко 713-1

using System;

public interface ISecondName
{
    string SecondName { get; }
}

public abstract class ChessFigure
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public char Color { get; private set; }

    protected ChessFigure(int x, int y, char color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public abstract string GetSecondName();
}

public abstract class LightFigure : ChessFigure, ISecondName
{
    public LightFigure(int x, int y, char color) : base(x, y, color) { }
    public virtual string SecondName => throw new NotImplementedException();
}

public abstract class HeavyFigure : ChessFigure
{
    public HeavyFigure(int x, int y, char color) : base(x, y, color) { }
}

public class Pawn_Chess_Figure : ChessFigure
{
    public Pawn_Chess_Figure(int x, int y, char color) : base(x, y, color) { }

    public override string GetSecondName() => "Пешка-Шахматная фигура, равна 1 силе.";
}

public class King_Chess_Figure : ChessFigure
{
    public King_Chess_Figure(int x, int y, char color) : base(x, y, color) { }

    public override string GetSecondName() => "Король-Бесценная шахматная фигура.";
}

public class Bishop_Light_Figure : LightFigure
{
    public Bishop_Light_Figure(int x, int y, char color) : base(x, y, color) { }

    public override string GetSecondName() => "Слон-Легкая фигура, равна 3 силам.";
}

public class Rook_Heavy_Figure : HeavyFigure
{
    public Rook_Heavy_Figure(int x, int y, char color) : base(x, y, color) { }

    public override string GetSecondName() => "Ладья-Тяжелая фигура, равна 5 силам.";
}

class Program
{
    static void Main()
    {
        ChessFigure[] figures = new ChessFigure[4];

        figures[0] = new King_Chess_Figure(0, 0, 'w');
        figures[1] = new Rook_Heavy_Figure(0, 0, 'b');
        figures[2] = new Bishop_Light_Figure(0, 0, 'b');
        figures[3] = new Pawn_Chess_Figure(0, 0, 'b');

        foreach (var figure in figures)
        {
            Console.WriteLine($"{figure.GetType().Name} {figure.GetSecondName()}");
        }
    }
}