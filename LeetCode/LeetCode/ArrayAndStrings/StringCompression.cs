using System.Text;

namespace LeetCode.ArrayAndStrings;

public class StringCompression
{
    public int Compress(char[] chars)
    {
        var count = 1;
        var index = 0;
        for (var i = 0; i < chars.Length; i++)
        {
            var c = chars[i];
            if (i < chars.Length - 1)
            {
                var next = chars[i + 1];
                if (next != c)
                {
                    chars[index++] = c;
                    if (count > 1)
                        foreach (var c1 in count.ToString().ToCharArray())
                            chars[index++] = c1;

                    count = 1;
                }
                else
                    count++;
            }
            else
            {
                chars[index++] = c;
                if (count > 1)
                    foreach (var c1 in count.ToString().ToCharArray())
                        chars[index++] = c1;
                
                break;
            }
        }

        return index;
    }
}