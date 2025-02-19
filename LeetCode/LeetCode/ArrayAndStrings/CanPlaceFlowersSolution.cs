namespace LeetCode.ArrayAndStrings;

public class CanPlaceFlowersSolution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;
        bool left, right;
        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1) continue;
            left = i == 0 || flowerbed[i - 1] == 0;
            right = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
            if (!left || !right || flowerbed[i] != 0) continue;

            n--;
            flowerbed[i] = 1;
            if (n == 0) return true;
        }

        return n <= 0;
    }
    public bool CanPlaceFlowersX(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1)
        {
            if (flowerbed[0] == 1 && n == 0) return true;
            return flowerbed[0] == 0 && n <= 1;
        }
        var countCanPlaceFlowers = 0;
        var prev = 0;
        var curr = flowerbed[0];
        var next = flowerbed[1];
        if (curr == 0 && next == 0)
        {
            countCanPlaceFlowers++;
            flowerbed[0] = 1;
        }

        for (var i = 1; i < flowerbed.Length - 1; i++)
        {
            prev = flowerbed[i - 1];
            curr = flowerbed[i];
            next = flowerbed[i + 1];
            if (prev == 0 && curr == 0 && next == 0)
            {
                countCanPlaceFlowers++;
                flowerbed[i] = 1;
            }
        }
        
        prev = flowerbed[^2];
        curr = flowerbed[^1];
        if (prev == 0 && curr == 0)
            countCanPlaceFlowers++;

        return countCanPlaceFlowers >= n;
    }
}