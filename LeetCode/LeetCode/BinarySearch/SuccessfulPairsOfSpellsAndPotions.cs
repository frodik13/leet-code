namespace LeetCode.BinarySearch;

public class SuccessfulPairsOfSpellsAndPotions
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var result = new int[spells.Length];
        potions = potions.Order().ToArray();

        for (var i = 0; i < spells.Length; i++)
        {
            long spell = spells[i];
            var left = 0;
            var right = potions.Length - 1;
            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                var potion = potions[middle] * spell;
                if (potion < success)
                {
                    left = middle + 1;
                }
                else if (potion >= success)
                {
                    right = middle - 1;
                }
            }

            result[i] = potions.Length - (left + (right - left) / 2);
        }

        return result;
    }
}