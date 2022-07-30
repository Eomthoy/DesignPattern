using System;

namespace DesignPattern
{
    /// <summary>
    /// 图形工厂实现
    /// </summary>
    public class ShapeImpl : AbstractFactory
    {
        public override AbstractFactoryType Type => AbstractFactoryType.Shape;

        public override IShape GetShape(ShapeType type)
        {
            return ShapeFactory.GetShape(type);
        }
    }
}