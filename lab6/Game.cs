interface IGame
{
    void StartGame();
    void PlayGame();
    void EndGame();
}

abstract class Game : IGame
{
    protected readonly string title;

    protected Game(string title)
    {
        this.title = title;
    }

    public abstract void StartGame();
    public abstract void PlayGame();
    public abstract void EndGame();

    public override string ToString()
    {
        return $"Game: {title}";
    }
}