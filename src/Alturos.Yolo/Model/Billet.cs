using System;

public class Billet
{
    /// <summary>
    /// Class of Billets containing the printed text and corresponding coordinates
    /// </summary>

    public string Text { get; set; }
    public double Confidence { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}
