using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tools;

namespace DesignPattern
{
    /// <summary>
    /// 图形工厂
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// 图形接口所有实现
        /// </summary>
        private static Dictionary<ShapeType, IShape> mImplDict = new Dictionary<ShapeType, IShape>();

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static ShapeFactory()
        {
            foreach (var impl in ReflectionTool.GetInterfaceImplList<IShape>())
            {
                if (mImplDict.ContainsKey(impl.Type))
                {
                    throw new Exception($"IShape已经有Type={impl.Type}的实现");
                }

                mImplDict[impl.Type] = impl;
            }
        }

        /// <summary>
        /// 获取图形
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public static IShape GetShape(ShapeType shapeType)
        {
            if (mImplDict.TryGetValue(shapeType, out var impl))
            {
                return impl;
            }

            return null;
        }
    }
}