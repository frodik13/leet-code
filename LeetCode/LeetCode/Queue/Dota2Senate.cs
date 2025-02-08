namespace LeetCode.Queue;

public class Dota2Senate
{
    private const string Radiant = "Radiant";
    private const string Dire = "Dire";
    
    public string PredictPartyVictory(string senate)
    {
        if (senate.All(c => c == 'R')) return Radiant;
        if (senate.All(c => c == 'D')) return Dire;
        
        Queue<char> queue = [];
        var radiantCount = 0;
        var direCount = 0;
        foreach (var c in senate)
        {
            queue.Enqueue(c);
            if (c == 'R') radiantCount++;
            else direCount++;
        }

        var radiantBanCount = 0;
        var direBanCount = 0;

        while (radiantCount > 0 && direCount > 0)
        {
            var senator = queue.Dequeue();
            if (senator == 'R')
            {
                if (radiantBanCount > 0)
                {
                    radiantBanCount--;
                    radiantCount--;
                }
                else
                {
                    direBanCount++;
                    queue.Enqueue(senator);
                }
            }
            else
            {
                if (direBanCount > 0)
                {
                    direBanCount--;
                    direCount--;
                }
                else
                {
                    radiantBanCount++;
                    queue.Enqueue(senator);
                }
            }
        }
        
        return radiantCount == 0 ? Dire : Radiant;
    }
}