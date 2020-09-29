using Auto.Commons.Ioc.IContract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Gbxx.BackStage.Configure.Ioc {
    /// <summary>
    /// AddSingleton的生命周期：
    /// 项目启动-项目关闭 相当于静态类  只会有一个
    /// AddScoped的生命周期：
    /// 请求开始-请求结束 在这次请求中获取的对象都是同一个
    /// AddTransient的生命周期：
    /// 请求获取-（GC回收-主动释放） 每一次获取的对象都不是同一个
    /// </summary>
    public static class IocExtensions {
        /// <summary>
        /// 注册指定程序集中的服务
        /// </summary>
        /// <param name="services">IServiceCollection类型的对象</param>
        public static void BatchServices(this IServiceCollection services) {
            Type iNeedInject = typeof(INeedInject);
            Type iTransientInject = typeof(ITransientInject);
            Type iScopedInject = typeof(IScopedInject);
            Type iSingletonInject = typeof(ISingletonInject);
            Type iNeedInjectNot = typeof(INeedInjectNot);//当接口切换实现类时，在旧的实现类上实现这个接口

            //所有程序集 和程序集下类型
            var deps = DependencyContext.Default;
            var libs = deps.CompileLibraries.Where(lib => !lib.Serviceable && lib.Type != "package");//排除所有的系统程序集、Nuget下载包
            var listAllType = new List<Type>();
            foreach (var lib in libs) {
                try {
                    var assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(lib.Name));
                    listAllType.AddRange(assembly.GetTypes().Where(type => type != null && iNeedInject.IsAssignableFrom(type) && type != iNeedInject));
                }
                catch { }
            }
            //找到所有外部IScopedInject实现，调用注册
            var scopedTypes = listAllType.Where(t => iScopedInject.IsAssignableFrom(t) && t != iScopedInject).ToArray();
            foreach (var interType in scopedTypes.Where(t => t.IsInterface)) {
                var entityType = scopedTypes.Where(t => t.IsClass && interType.IsAssignableFrom(t) && !iNeedInjectNot.IsAssignableFrom(t)).SingleOrDefault();
                if (entityType != null)
                    services.AddScoped(interType, entityType);
            }

            //找到所有外部ITransientInject实现，调用注册
            var transientTypes = listAllType.Where(t => iTransientInject.IsAssignableFrom(t) && t != iTransientInject).ToArray();
            foreach (var interType in transientTypes.Where(t => t.IsInterface)) {
                var entityType = transientTypes.Where(t => t.IsClass && interType.IsAssignableFrom(t) && !iNeedInjectNot.IsAssignableFrom(t)).SingleOrDefault();
                if (entityType != null)
                    services.AddTransient(interType, entityType);
            }
            //找到所有外部ISingletonInject实现，调用注册
            var singletonTypes = listAllType.Where(t => iSingletonInject.IsAssignableFrom(t) && t != iSingletonInject).ToArray();
            foreach (var interType in singletonTypes.Where(t => t.IsInterface)) {
                var entityType = singletonTypes.Where(t => t.IsClass && interType.IsAssignableFrom(t) && !iNeedInjectNot.IsAssignableFrom(t)).SingleOrDefault();
                if (entityType != null)
                    services.AddSingleton(interType, entityType);
            }
        }
    }
}
