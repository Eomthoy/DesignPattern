using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class SquareImpl : IShape
    {
        public ShapeType Type => ShapeType.Square;

        public void Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }
}