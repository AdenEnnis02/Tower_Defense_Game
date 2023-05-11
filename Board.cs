using Raylib_cs;
using System;

public class GameBoard
{
    private const int CellSize = 50;
    private const int BoardSize = 18;
    private Color[,] boardColors = new Color[BoardSize, BoardSize];
    private bool[,] redSquares = new bool[BoardSize, BoardSize];

    public GameBoard()
    {
        // Initialize the board colors
        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    boardColors[row, col] = Color.WHITE;
                }
                else
                {
                    boardColors[row, col] = Color.BLACK;
                }

                redSquares[row, col] = false;
            }
        }

        // Mark specific squares as red
        redSquares[3, 0] = true;
        redSquares[3, 1] = true;
        redSquares[3, 2] = true;
        redSquares[3, 3] = true;
        redSquares[3, 4] = true;
        redSquares[4, 4] = true;
        redSquares[5, 4] = true;
        // Add more red squares as needed
    }

    public void Draw()
    {
        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                Rectangle rect = new Rectangle(col * CellSize, row * CellSize, CellSize, CellSize);

                if (redSquares[row, col])
                {
                    Raylib.DrawRectangleRec(rect, Color.RED);
                }
                else
                {
                    Raylib.DrawRectangleRec(rect, boardColors[row, col]);
                }
            }
        }
    }
}