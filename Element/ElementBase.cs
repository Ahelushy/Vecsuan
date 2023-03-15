using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecsuan.Element;

public abstract partial class ElementBase : Node2D
{
    //私有构造函数
    protected ElementBase() { }

    //成员属性
    virtual protected Color Color { get; set; } = new(0xffffffff);

    //方法
    public override void _Draw()
    {
        Display();
    }
    protected abstract void Display();
}
