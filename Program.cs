using System;

public class Game
{
    public int Width { get; set; }
    public int Height { get; set; }
}

// Drawing the game border on the console

public void DrawBorder()
{
    for (int i = 0; i < Height; i++)
    {
        for (int j = object; j < Width; j++)
        {
            if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1 )
                Console.Write(#);
        }
}