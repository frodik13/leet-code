namespace LeetCode.GraphsDepthFirstSearch;

public class KeysAndRooms
{
    public bool CanVisitAllRooms(List<List<int>> rooms)
    {
        var visitedRooms = new bool[rooms.Count];
        
        Visit(visitedRooms, rooms, 0);
        return visitedRooms.All(visitedRoom => visitedRoom);
    }

    private void Visit(bool[] visitedRooms, List<List<int>> rooms, int index)
    {
        visitedRooms[index] = true;
        
        var keys = rooms[index];

        foreach (var key in keys)
        {
            if (visitedRooms[key]) continue;
            
            Visit(visitedRooms, rooms, key);
        }
    }

    public bool CanVisitAllRoomsX(List<List<int>> rooms)
    {
        var visited = new HashSet<int>();
        var queue = new Queue<IList<int>>();
        queue.Enqueue(rooms[0]);
        visited.Add(0);
        
        while (queue.Count > 0)
        {
            var keysRooms = queue.Dequeue();
            foreach (var keysRoom in keysRooms)
            {
                if (visited.Contains(keysRoom)) continue;
                
                queue.Enqueue(rooms[keysRoom]);
                visited.Add(keysRoom);
            }
        }

        return visited.Count == rooms.Count;
    }
}