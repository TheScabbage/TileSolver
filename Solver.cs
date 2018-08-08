


/// Solves a grid of tiles, where T is the object stored in every cell.
public static class Solver<T>
{
    // Creates a grid representation of an array of objects.
    // The dimensions parameter defines the dimensions of the grid
    // eg. [4, 7, 3] Would be a size x=4, y=7, z=3 grid.
    // The objects array must have a length equal to the product of all dimensions.
    public TileGrid<T> CreateGrid(int[] dimensions, T[] objects)
    {
        int objCount = 1;
        for(int ii = 0; ii < dimensions; ii++)
        {
            objCount *= dimensions[ii];
        }
        if(objCount != objects.Length)
        {
            throw new System.ArgumentException();
        }

        TileGrid<T> result = new TileGrid<T>(dimensions);
    }

    public IEnumerable<Move> Solve(TileGrid<T> grid)
    {

    }

    private Move[] BigSwap(TileGrid<T> grid, int[] nodeA, int[] nodeB)
    {
        if(nodeA.Length != nodeB.Length)
            throw new System.ArgumentException();

        int distance = 0;
        int axisDist;
        for(int ii = 0; ii < nodeA.Length; ii++)
        {
            axisDist = nodeA[ii] - nodeB[ii];
            distance += axisDist > 0 ? axisDist : -axisDist;
        }
        
        Move[] result = new Move[];
        

    }

}