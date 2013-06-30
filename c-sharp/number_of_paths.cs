// find the number of paths through a grid
// This won't work for a large grid:

class Program
{
    static int paths = 0;
    static int grid_size = 3;
    static void traverse(int[,] grid, List< Tuple< int, int>> path, int x, int y)
    {
        path.Add(new Tuple< int, int>(x, y));
        if (x == grid_size && y == grid_size)
        {
            // at the end
            foreach(Tuple< int,int>t in path)
                Console.Write("{0},{1} - ", t.Item1, t.Item2);
            Console.WriteLine();
            ++paths;
            path.Clear();
        }
        else // branch
        {
            // go right
            if (x < grid_size)
                traverse(grid, new List< Tuple< int, int>>(path), x + 1, y);
            // go down
            if (y < grid_size)
                traverse(grid, new List< Tuple< int, int>>(path), x, y + 1);
        }
    }

    static void Main(string[] args)
    {
        int[,] grid = new int[grid_size, grid_size];
        List< Tuple> path = new List< Tuple>();
        traverse(grid, path, 0, 0);
        Console.WriteLine("\n\npaths: {0}", paths);
    }
}


// What will work, is a combination formula (& bigint support)

// >>> f=math.factorial
// >>> f(40)/(f(20)*f(20))


//<sigh>