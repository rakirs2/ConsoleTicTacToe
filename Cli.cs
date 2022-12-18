namespace ConsoleTicTacToe;

public class Cli
{
    private TicTacToeGame _tacToeGame;

    public Cli()
    {
        OpeningExplanation();
    }

    void OpeningExplanation()
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

        if (input == "1")
        {
            _tacToeGame = new TicTacToeGame();
        }
    }

    static HashSet<string> validGameChoices = new HashSet<string>(){"1", "2", "3" };
}