using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class BlueImpl : IColor
    {
        public ColorType Type => ColorType.Blue;

        public void Fill()
        {
            Console.WriteLine("Fill Blue");
        }
    }
}