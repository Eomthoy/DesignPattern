using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class RectangleImpl : IShape
    {
        public ShapeType Type => ShapeType.Rectangle;

        public void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
}