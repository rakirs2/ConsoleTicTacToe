namespace ConsoleTicTacToe;

public class Cli
{
    private static readonly HashSet<string> validGameChoices = new() { "1", "2", "3" };
    private TicTacToeGame _tacToeGame;

    public Cli()
    {
        OpeningExplanation();
    }

    private void OpeningExplanation()
    {
        PickAGame();
    }

    internal void PickAGame()
    {
        var input = "0";
        while (!validGameChoices.Contains(input))
        {
            Console.WriteLine(
                "Pick An Option \n1. Play against a human\n2. Play against a random computer\n3. Never win again");
            input = Console.ReadLine();
        }

        if (input == "1") _tacToeGame = new TicTacToeGame();
    }
}