using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;
using Vecsuan.Element;

namespace Vecsuan.Program;

internal partial class InputHandler : Node
{
	//构造函数
	private InputHandler() { }

	//成员属性
	private Node Root { get; set; }

	//方法重写
	public override void _Ready()
	{
		Root = GetParent();
	}
	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseButton)
		{
			if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
			{
				var point = Point.NewInstance(mouseButton.GlobalPosition);
				Root.AddChild(point);
				GetViewport().SetInputAsHandled();
			}
		}
	}
}
