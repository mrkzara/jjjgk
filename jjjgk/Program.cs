using System;

namespace OCP_Mark_Zara
{
    class Program
    {
        static void Main(string[] args)
        {
            var pencilTool = new PencilTool();
            pencilTool.mouseOver();
        }
    }
}


public interface IPaintTool
{
    void mouseOver();

    void mouseUp();

}

public class PencilTool:IPaintTool
{
   
    public void mouseOver()
    {
        Console.WriteLine("Show pencil icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Draw a line.");
    }
}

public class SquareTool : IPaintTool
{
    public void mouseOver()
    {
        Console.WriteLine("Show square icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Draw a square.");
    }
}

public class EraserTool : IPaintTool
{
    public void mouseOver()
    {
        Console.WriteLine("Show an eraser icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Erase the selected object.");
    }
}
