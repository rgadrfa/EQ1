using System.Diagnostics;
using SOLVER;

class Program
{
    public static void Main()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var matrix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var indexArray = new int[] { 0, 3 };
        
        Console.WriteLine("Проверка");
        //Проверка
        var result = Solver.GetSubarray(array, indexArray);
    }
}

