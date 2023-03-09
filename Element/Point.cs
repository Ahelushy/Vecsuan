using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace Vecsuan.Element
{
    public partial class Point : Node2D
    {
        //工厂
        private Point() { }
        private static readonly PackedScene Scene = GD.Load<PackedScene>("res://Element/Point.tscn");
        public static Point NewInstance() => Scene.Instantiate<Point>();
        public static Point NewInstance(Vector2 position)
        {
            var resultInstance = NewInstance();
            resultInstance.Position = position;
            return resultInstance;
        }

        //显示
        [Export]
        private Color Color { get; set; }
        public override void _Draw()
        {
            DrawCircle(Vector2.Zero, 10, Color);
        }
    }
}
