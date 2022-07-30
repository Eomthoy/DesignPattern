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
        /// 获取实现接口的所有实例
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <returns></returns>
        public static List<T> GetInterfaceImplList<T>()
        {
            var result = new List<T>();

            var a = typeof(T);

            foreach (var type in Assembly.GetAssembly(typeof(T)).GetTypes())
            {
                if (type.IsInterface == false && type.GetInterfaces().Contains(typeof(T)))
                {
                    var impl = (T)Activator.CreateInstance(type);
                    result.Add(impl);
                }
            }

            return result;
        }
    }
}
