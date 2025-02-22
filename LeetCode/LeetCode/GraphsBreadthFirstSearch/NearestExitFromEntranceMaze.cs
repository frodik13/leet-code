namespace LeetCode.GraphsBreadthFirstSearch;

public class NearestExitFromEntranceMaze
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        var queue = new Queue<(int row, int column, int stepsCount)>();

        var dy = new[] { -1, 1, 0, 0 };
        var dx = new[] { 0, 0, -1, 1 };

        var rowsCount = maze.Length;
        var columnsCount = maze[0].Length;

        var startRow = entrance[0];
        var startColumn = entrance[1];

        queue.Enqueue((startRow, startColumn, 0));

        while (queue.TryDequeue(out var position))
        {
            for (var i = 0; i < 4; i++)
            {
                var newX = position.row + dx[i];
                var newY = position.column + dy[i];

                if (newX >= 0 && newY >= 0 && newX < rowsCount && newY < columnsCount && maze[newX][newY] == '.')
                {
                    if ((newX == 0 || newY == 0 || newX == rowsCount - 1 || newY == columnsCount - 1)
                        && (newX != startRow || newY != startColumn))
                    {
                        return position.stepsCount + 1;
                    }

                    queue.Enqueue((newX, newY, position.stepsCount + 1));
                    maze[newX][newY] = '+';
                }
            }
        }

        return -1;
    }


    public int NearestExitX(char[][] maze, int[] entrance)
    {
        var visited = new bool[maze.Length][];
        for (var i = 0; i < visited.Length; i++)
            visited[i] = new bool[maze[i].Length];

        visited[entrance[0]][entrance[1]] = true;

        var queue = new Queue<(int row, int column, int stepsCount)>();
        queue.Enqueue((entrance[0], entrance[1], 0));

        while (queue.TryDequeue(out var position))
        {
            if (IsExit(position, entrance, maze))
            {
                return position.stepsCount;
            }

            WalkThroughAdjacentCells(maze, position, visited, queue);
        }

        return -1;
    }

    private static void WalkThroughAdjacentCells(char[][] maze, (int row, int column, int stepsCount) position,
        bool[][] visited, Queue<(int row, int column, int stepsCount)> queue)
    {
        if (position.row > 0 && CheckNextStep(position.row - 1, position.column, maze, visited))
        {
            queue.Enqueue((position.row - 1, position.column, position.stepsCount + 1));
            visited[position.row - 1][position.column] = true;
        }

        if (position.row < maze.Length - 1 
            && CheckNextStep(position.row + 1, position.column, maze, visited))
        {
            queue.Enqueue((position.row + 1, position.column, position.stepsCount + 1));
            visited[position.row + 1][position.column] = true;
        }

        if (position.column > 0 && CheckNextStep(position.row, position.column - 1, maze, visited))
        {
            queue.Enqueue((position.row, position.column - 1, position.stepsCount + 1));
            visited[position.row][position.column - 1] = true;
        }

        if (position.column < maze[0].Length - 1
            && CheckNextStep(position.row, position.column + 1, maze, visited))
        {
            queue.Enqueue((position.row, position.column + 1, position.stepsCount + 1));
            visited[position.row][position.column + 1] = true;
        }
    }

    private static bool IsExit((int row, int column, int stepCount) position, int[] entrance, char[][] maze)
    {
        return (position.row == 0 || position.column == 0 || position.row == maze.Length - 1 ||
                position.column == maze[0].Length - 1) &&
               (position.row != entrance[0] || position.column != entrance[1]);
    }

    private static bool CheckNextStep(int nextRow, int nextColumn, char[][] maze, bool[][] visited)
    {
        return maze[nextRow][nextColumn] == '.' && visited[nextRow][nextColumn] == false;
    }
}