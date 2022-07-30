using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tools;

namespace DesignPattern
{
    /// <summary>
    /// 工厂生产者
    /// </summary>
    public class FactoryProducer
    {
        /// <summary>
        /// 图形接口所有实现
        /// </summary>
        private static Dictionary<AbstractFactoryType, AbstractFactory> mImplDict = new Dictionary<AbstractFactoryType, AbstractFactory>();

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static FactoryProducer()
        {
            foreach (var impl in ReflectionTool.GetInheritImplList<AbstractFactory>())
            {
                if (mImplDict.ContainsKey(impl.Type))
                {
                    throw new Exception($"IColor已经有Type={impl.Type}的实现");
                }

                mImplDict[impl.Type] = impl;
            }
        }

        /// <summary>
        /// 获取工厂
        /// </summary>
        /// <param name="type">工厂类型</param>
        /// <returns></returns>
        public static AbstractFactory GetFactory(AbstractFactoryType type)
        {
            if (mImplDict.TryGetValue(type, out var impl))
            {
                return impl;
            }

            return null;
        }
    }
}