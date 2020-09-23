using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.Ioc.IContract {
    /// <summary>
    /// 项目启动-项目关闭(唯一的)
    /// 整个应用程序生命周期以内只创建一个实例，相当于一个静态类。
    /// </summary>
    public interface ISingletonInject: INeedInject {
    }
}
