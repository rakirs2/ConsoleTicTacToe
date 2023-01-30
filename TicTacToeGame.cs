namespace ConsoleTicTacToe;

public class TicTacToeGame
{
    private readonly char[][] board;
    private bool hasWinner = false;
    private bool isXTurn = true;

    private HashSet<string> squaresLeft = new() { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3" };

    public TicTacToeGame()
    {
        board = new char[3][];
        board[0] = new char[3] { ' ', ' ', ' ' };
        board[1] = new char[3] { ' ', ' ', ' ' };
        board[2] = new char[3] { ' ', ' ', ' ' };

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

    public void FirstInstructions()
    {
        Console.WriteLine("X goes first. Valid inputs are shown below");
    }
}