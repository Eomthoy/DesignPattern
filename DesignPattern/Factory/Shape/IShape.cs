using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// 类型
        /// </summary>
        ShapeType Type { get; }

        /// <summary>
        /// 画图
        /// </summary>
        void Draw();
    }
}