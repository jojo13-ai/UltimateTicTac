namespace UltimateTicTac.Models;

public class Board
{
    private IReadOnlyList<Cell> Cells { get; }

    public Board()
    {
        Cells = new Cell[] { };
    }
}