using System;

public class Kata
{
    public static double Solution(int[] firstArray, int[] secondArray)
    {
        double sum = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            int diff = firstArray[i] - secondArray[i];
            sum += Math.Pow(diff, 2);
        }

        return sum / firstArray.Length;
    }
}
