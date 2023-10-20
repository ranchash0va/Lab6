

class Program
{
    static void Main(string[] args)
    {
       
        BoardGame boardGame1 = new BoardGame("Chess", 2);
        BoardGame boardGame2 = new BoardGame("Monopoly", 4);

       
        List<IGame> gamesList = new List<IGame> { boardGame1, boardGame2 };

        // Вывод начального содержимого списка на экран
        Console.WriteLine("Initial List:");
        PrintGames(gamesList);

        // Рандомное редактирование элементов списка
        Random random = new Random();
        int indexToEdit = random.Next(gamesList.Count);
        gamesList[indexToEdit] = new BoardGame("Checkers", random.Next(2, 6));

        // Вывод отредактированного содержимого списка на экран
        Console.WriteLine("\nUpdated List:");
        PrintGames(gamesList);

        // Добавление новой игры в список
        BoardGame newBoardGame = new BoardGame("Risk", random.Next(2, 6));
        gamesList.Add(newBoardGame);

        // Вывод содержимого списка после добавления новой игры
        Console.WriteLine("\nList after adding a new game:");
        PrintGames(gamesList);

        // Генерация случайного индекса для удаления элемента
        int indexToRemove = random.Next(gamesList.Count);
        gamesList.RemoveAt(indexToRemove);

        // Вывод содержимого списка после удаления случайного элемента
        Console.WriteLine($"\nList after removing the game at index {indexToRemove}:");
        PrintGames(gamesList);
    }

    static void PrintGames(List<IGame> games)
    {
        foreach (IGame game in games)
        {
            Console.WriteLine(game);
            game.StartGame();
            game.PlayGame();
            game.EndGame();
            Console.WriteLine();
        }
    }
}