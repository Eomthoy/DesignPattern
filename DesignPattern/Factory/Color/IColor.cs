using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// 类型
        /// </summary>
        ColorType Type { get; }

        /// <summary>
        /// 填充
        /// </summary>
        void Fill();
    }
}