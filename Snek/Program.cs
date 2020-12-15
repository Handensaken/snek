using System;
using Raylib_cs;

namespace Snek
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800,600, "Snek");
            Raylib.SetTargetFPS(60);

            Grid grid = new Grid();

            while(!Raylib.WindowShouldClose()){
                //MATTE VRRR





                //FIN BILD VRRR
                Raylib.BeginDrawing();
                //Raylib.ClearBackground(Color.WHITE);
                grid.Draw();
                Raylib.EndDrawing();
            }
        }
    }
}
