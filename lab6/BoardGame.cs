using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BoardGame : Game
{
    // Добавьте свои свойства и методы для класса BoardGame
    // Например:
    private int numberOfPlayers;

    public BoardGame(string title, int numberOfPlayers) : base(title)
    {
        this.numberOfPlayers = numberOfPlayers;
    }

    public override void StartGame()
    {
        Console.WriteLine($"Starting the board game: {title} for {numberOfPlayers} players.");
    }

    public override void PlayGame()
    {
        Console.WriteLine($"Playing the board game: {title}.");
    }

    public override void EndGame()
    {
        Console.WriteLine($"Ending the board game: {title}.");
    }

    public override string ToString()
    {
        return $"Board Game: {title} (Players: {numberOfPlayers})";
    }
}
