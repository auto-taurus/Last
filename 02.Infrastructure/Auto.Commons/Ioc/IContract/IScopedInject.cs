using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.Ioc.IContract {
    /// <summary>
    /// 请求开始-请求结束(作用域的)
    /// 在同一个Scope内只初始化一个实例 ，可以理解为（ 每一个request级别只创建一个实例，同一个http request会在一个 scope内）。
    /// </summary>
    public interface IScopedInject : INeedInject {

    }
}
