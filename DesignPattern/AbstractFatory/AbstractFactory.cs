using System;

namespace DesignPattern
{
    /// <summary>
    /// 抽象工厂接口
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 工厂类型
        /// </summary>
        public abstract AbstractFactoryType Type { get; }

        /// <summary>
        /// 获取图形
        /// </summary>
        /// <returns></returns>
        public virtual IShape GetShape(ShapeType type)
        {
            return null;
        }

        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <returns></returns>
        public virtual IColor GetColor(ColorType type)
        {
            return null;
        }
    }
}