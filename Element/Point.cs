using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace Vecsuan.Element;

public partial class Point : ElementBase
{
    //工厂
    private static readonly PackedScene Scene = GD.Load<PackedScene>("res://Element/Point.tscn");
    public static Point NewInstance() => Scene.Instantiate<Point>();
    public static Point NewInstance(Vector2 position)
    {
        var resultInstance = NewInstance();
        resultInstance.Position = position;
        return resultInstance;
    }

    //显示
    protected override void Display()
    {
        DrawCircle(Vector2.Zero, 10, Color);
    }
}
