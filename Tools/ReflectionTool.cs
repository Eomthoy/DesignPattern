using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tools
{
    /// <summary>
    /// 反射工具类
    /// </summary>
    public class ReflectionTool
    {
        /// <summary>
        /// 获取实现接口的所有实现类实例
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <returns></returns>
        public static List<T> GetInterfaceImplList<T>()
        {
            var result = new List<T>();

            var interfaceType = typeof(T);

            foreach (var type in Assembly.GetAssembly(interfaceType).GetTypes())
            {
                if (type.IsInterface == false && type.GetInterfaces().Contains(interfaceType))
                {
                    result.Add((T)Activator.CreateInstance(type));
                }
            }

            return result;
        }

        /// <summary>
        /// 获取继承所有派生类实例
        /// </summary>
        /// <typeparam name="T">父类类型</typeparam>
        /// <returns></returns>
        public static List<T> GetInheritImplList<T>()
        {
            var result = new List<T>();

            var parentType = typeof(T);

            foreach (var type in Assembly.GetAssembly(parentType).GetTypes())
            {
                if (parentType.IsAssignableFrom(type) && parentType != type)
                {
                    result.Add((T)Activator.CreateInstance(type));
                }
            }

            return result;
        }
    }
}
