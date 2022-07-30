using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class RedImpl : IColor
    {
        public ColorType Type => ColorType.Red;

        public void Fill()
        {
            Console.WriteLine("Fill Red");
        }
    }
}