

// Defines a move on a TileGrid
public struct Move
{
    public enum SwapDirection {PosX, PosY, PosZ, NegX, NegY, NegZ};
    public readonly int[] cellPosition;
    public readonly SwapDirection swapDirection;
}
