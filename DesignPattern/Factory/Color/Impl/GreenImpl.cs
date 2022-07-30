using System;

namespace DesignPattern
{
    /// <summary>
    /// 工厂模式接口
    /// </summary>
    public class GreenImpl : IColor
    {
        public ColorType Type => ColorType.Green;

        public void Fill()
        {
            Console.WriteLine("Fill Green");
        }
    }
}