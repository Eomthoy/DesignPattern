using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tools;

namespace DesignPattern
{
    /// <summary>
    /// 颜色工厂
    /// </summary>
    public class ColorFactory
    {
        /// <summary>
        /// 图形接口所有实现
        /// </summary>
        private static Dictionary<ColorType, IColor> mImplDict = new Dictionary<ColorType, IColor>();

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static ColorFactory()
        {
            foreach (var impl in ReflectionTool.GetInterfaceImplList<IColor>())
            {
                if (mImplDict.ContainsKey(impl.Type))
                {
                    throw new Exception($"IColor已经有Type={impl.Type}的实现");
                }

                mImplDict[impl.Type] = impl;
            }
        }

        /// <summary>
        /// 获取图形
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public static IColor GetColor(ColorType shapeType)
        {
            if (mImplDict.TryGetValue(shapeType, out var impl))
            {
                return impl;
            }

            return null;
        }
    }
}