using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class SquareImpl : IShape
    {
        ShapeType IShape.Type => ShapeType.Square;

        void IShape.Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }
}