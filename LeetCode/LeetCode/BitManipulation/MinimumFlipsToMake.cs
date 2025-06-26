using System.Numerics;

namespace LeetCode.BitManipulation;

public class MinimumFlipsToMake
{
    public int MinFlips(int a, int b, int c)
    {
        // Все биты, где с == 0
        // Там a и b должны быть 0 - если где-то 1, нужно сбросить.
        var toZeroA = a & ~c;
        var toZeroB = b & ~c;
        
        // Все биты, где с == 1, но (a|b) == 0 - нужно включить хотя бы один.
        var orAB = a | b;
        var toOne = ~orAB & c;
        
        return CountSetBitsOperations(toZeroA) + CountSetBitsOperations(toZeroB) + CountSetBitsOperations(toOne);
    }

    private int CountSetBits(int n)
    {
        // Алгоритм Кернигана — это эффективный алгоритм для подсчёта количества установленных
        // битов (единиц) в двоичном представлении целого числа.
        // Алгоритм использует следующую закономерность:
        // Выражение n & (n - 1) сбрасывает самый младший установленный бит в числе n.
        // Например:
        //         n = 12 = 1100₂
        //         n - 1 = 11 = 1011₂
        //         n & (n - 1) = 1100 & 1011 = 1000₂
        // Таким образом, в каждом шаге алгоритм "снимает" по одному установленному биту, пока число не станет равно 0.
        var count = 0;
        while (n != 0)
        {
            n &= n - 1;
            count++;;
        }

        return count;
    }

    private int CountSetBitsOperations(int n)
    {
        return BitOperations.PopCount((uint)n);
    }
}