using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class CricleImpl : IShape
    {
        public ShapeType Type => ShapeType.Cricle;

        public void Draw()
        {
            Console.WriteLine("Draw a Cricle");
        }
    }
}