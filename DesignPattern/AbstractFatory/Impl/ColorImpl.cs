using System;

namespace DesignPattern
{
    /// <summary>
    /// 颜色工厂实现
    /// </summary>
    public class ColorImpl : AbstractFactory
    {
        public override AbstractFactoryType Type => AbstractFactoryType.Color;

        public override IColor GetColor(ColorType type)
        {
            return ColorFactory.GetColor(type);
        }
    }
}