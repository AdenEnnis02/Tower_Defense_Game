          

using Raylib_cs;
using System.Numerics;

public class SideBar
{
    
        public void DrawToweroptions()
    {
            Raylib.DrawRectangle(950,100,50,50, Color.BLUE); // horizontal position, vertical , width, length
            Raylib.DrawRectangle(1050,100,50,50, Color.YELLOW);
            Raylib.DrawRectangle(950,200,50,50, Color.ORANGE); 
            Raylib.DrawRectangle(1050,200,50,50, Color.PURPLE);
            Raylib.DrawRectangle(925,800,200,100, Color.GREEN); 

    }



}