
using System;
using Raylib_cs;
using System.Numerics;

public class GameLoop
{
    public static void Main()
    {
        const int screenWidth = 1150;
        const int screenHeight = 900;

        Raylib.InitWindow(screenWidth, screenHeight, "Mouse Support");

        Raylib.SetTargetFPS(60);

        //Make instances of other classes here
        Mouse mouseController = new Mouse();
        GameBoard gameBoard = new GameBoard();
        MakeSquares MS = new MakeSquares();
        SideBar SB = new SideBar();

        while (!Raylib.WindowShouldClose())
        {
            mouseController.Update();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            //Add functions from other classes here.
            gameBoard.Draw();
            mouseController.DrawCursor();
            SB.DrawToweroptions();
            

            
            

            Raylib.DrawText("Move the mouse to change the cursor's position", 10, 10, 20, Color.GRAY);
            Raylib.DrawText("Click the left mouse button to change the cursor's color", 10, 40, 20, Color.GRAY);



            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}



