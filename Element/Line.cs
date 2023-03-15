using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vecsuan.Element;

internal partial class Line : ElementBase
{
    //成员属性
    private readonly Point[] _EndPoints = new Point[2];
    public Point[] EndPoints { get => _EndPoints.ToArray(); }
    public Vector2[] EndPositions { get => (from endPoint in _EndPoints select endPoint.Position).ToArray(); }

    //工厂
    private static readonly PackedScene Scene = GD.Load<PackedScene>("res://Element/Line.tscn");
    public static Line NewInstance(Point start, Point end)
    {
        var result = Scene.Instantiate<Line>();
        result._EndPoints[0] = start;
        result._EndPoints[1] = end;
        return result;
    }

    //显示
    protected override void Display()
    {
        DrawLine(EndPositions[0], EndPositions[1], Color);
    }
}
