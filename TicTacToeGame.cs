namespace ConsoleTicTacToe;

public class TicTacToeGame
{
    private readonly char[][] board;
    private bool hasWinner = false;
    private bool isXTurn = true;

    private Dictionary<string, (int, int)> squaresLeft = new Dictionary<string, (int, int)>();
    



          public TicTacToeGame()
    {
        board = new char[3][];
        board[0] = new char[3] { ' ', ' ', ' ' };
        board[1] = new char[3] { ' ', ' ', ' ' };
        board[2] = new char[3] { ' ', ' ', ' ' };

        squaresLeft.Add("1a", (0,0));
        squaresLeft.Add("2a", (1,0));
        squaresLeft.Add("3a", (2,0));
        squaresLeft.Add("1b", (0, 1));
        squaresLeft.Add("2b", (1,1));
        squaresLeft.Add("3b", (2,1));
        squaresLeft.Add("1c", (0, 2));
        squaresLeft.Add("2c", (1,2));
        squaresLeft.Add("3c", (2,2));
        Template();
        Console.WriteLine(ToString());
        FirstInstructions();
    }

    private static void Template()
    {
        Console.WriteLine(""" 
             a     b     c
                |     |     
          1  1a |  1b |  1c  
           _____|_____|_____
                |     |     
          2  2a |  2b |  2c 
           _____|_____|_____
                |     |     
          3  3a |  3b |  3c  
                |     |      
          """);
    }

    public string ToString()
    {
        return $""" 
             a     b     c
                |     |     
          1  {board[0][0]}  |  {board[0][1]}  |  {board[0][2]}  
           _____|_____|_____
                |     |     
          2  {board[1][0]}  |   {board[1][1]} |  {board[1][2]} 
           _____|_____|_____
                |     |     
          3  {board[2][0]}  |  {board[2][1]}  |  {board[2][2]}  
                |     |      
          """;
    }

    private void FirstInstructions()
    {
        Console.WriteLine("X goes first. Valid inputs are shown below");
    }

    private void PrintValidLocations()
    {
          
    }
    }