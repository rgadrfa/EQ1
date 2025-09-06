namespace SOLVER;

public static class Solver
{
    public static int[] GetSubarray(int[] array, int[] indexSubArray)
    {
        var indexStart = indexSubArray[0];
        var indexStop = indexSubArray[1] + 1;
        
        var subArray = new List<int>();
        for (var i = indexStart; i <  indexStop; i++)
            subArray.Add(array[i]);
        return subArray.ToArray();
    }
}