namespace LeetCode.DynamicProgramming;

public class NThTribonacciNumber
{
    public int Tribonacci(int n)
    {
        var tribonacci = new int[n + 3];
        tribonacci[0] = 0;
        tribonacci[1] = 1;
        tribonacci[2] = 1;

        for (var i = 0; i < n; i++)
        {
            tribonacci[i + 3] = tribonacci[i] + tribonacci[i + 1] + tribonacci[i + 2]; 
        }
        
        return tribonacci[n];
    }
}