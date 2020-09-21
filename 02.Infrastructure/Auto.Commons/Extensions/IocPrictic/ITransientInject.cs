using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.Extensions.IocPrictic {
    /// <summary>
    /// 请求获取-（GC回收-主动释放） 每一次获取的对象都不是同一个(瞬时的)
    /// 每一次都会创建一个新的实例。
    /// </summary>
    public interface ITransientInject : INeedInject {
    }
}
