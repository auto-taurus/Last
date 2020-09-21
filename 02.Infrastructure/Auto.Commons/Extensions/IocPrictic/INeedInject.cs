﻿/// <summary>
/// 1、定义一个需要依赖注入的标记接口（INeedInject），这个接口里面什么也没有，仅仅标记一个接口需要进行依赖注入。
/// 2、定义三个生命周期接口，这个三个接口里面什么也没有（ITransientInject、IScopedInject、ISingletonInject），仅仅作为一个类型，在利用反射的时候让其选择对应的生命周期注入方式。
/// 3、定义一个不需要依赖注入的标记接口(INeedInjectNot),这个接口是在我们需要更换接口实现类的时候，在旧的实现类上实现这个接口，让反射程序跳过这个实现类，去注入新的类。
/// 4、生命周期接口继承需要依赖注入的标记接口（INeedInject）。
/// 5、需要依赖注入的接口继承三种生命周期接口中的其中一种。
/// 6、实现类实现需要依赖注入的接口。
/// 7、利用反射更具标记接口（INeedInject）筛选出那些接口需要进行依赖注入。
/// 8、利用反射找到这个需要进行依赖注入接口的唯一实现类。
/// 9、根据接口定义的注入类型，选择合适的生命周期类型去实现注入。
/// 10、调用依赖注入的对象
/// </summary>
namespace Auto.Commons.Extensions.IocPrictic {
    /// <summary>
    /// 需要注入
    /// </summary>
    public interface INeedInject {
    }
}
