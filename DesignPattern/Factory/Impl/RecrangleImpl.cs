using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class RecrangleImpl : IShape
    {
        ShapeType IShape.Type => ShapeType.Recrangle;

        void IShape.Draw()
        {
            Console.WriteLine("Draw a Recrangle");
        }
    }
}