using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class CricleImpl : IShape
    {
        ShapeType IShape.Type => ShapeType.Cricle;

        void IShape.Draw()
        {
            Console.WriteLine("Draw a Cricle");
        }
    }
}