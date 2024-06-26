namespace UltimateTicTac.Models;

public class GameManager
{
    private Board GameBoard { get; set; }

    private Player Player1 { get; set; }

    private Player Player2 { get; set; }

    public GameManager()
    {
        GameBoard = new Board();

        Console.WriteLine("Введите имя 1го игрока");
        Player1 = new Player(Console.ReadLine() ?? "Игрок 1");

        Console.WriteLine("Введите имя 2го игрока");
        Player2 = new Player(Console.ReadLine() ?? "Игрок 2");
    }

    public void StartGame()
    {
        Console.WriteLine("Game started");
    }
}