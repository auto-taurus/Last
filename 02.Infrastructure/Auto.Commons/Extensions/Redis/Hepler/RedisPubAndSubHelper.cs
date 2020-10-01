using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.Extensions.Redis.Hepler {
    public partial class RedisRepository {
        //#region 发布订阅

        ///// <summary>
        ///// Redis发布订阅  订阅
        ///// </summary>
        ///// <param name="subChannel"></param>
        ///// <param name="handler"></param>
        //public void Subscribe(string subChannel, Action<RedisChannel, RedisValue> handler = null) {
        //    ISubscriber sub = _conn.GetSubscriber();
        //    sub.Subscribe(subChannel, (channel, message) => {
        //        if (handler == null) {
        //            Console.WriteLine(subChannel + " 订阅收到消息：" + message);
        //        }
        //        else {
        //            handler(channel, message);
        //        }
        //    });
        //}

        ///// <summary>
        ///// Redis发布订阅  发布
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="channel"></param>
        ///// <param name="msg"></param>
        ///// <returns></returns>
        //public long Publish<T>(string channel, T msg) {
        //    ISubscriber sub = _conn.GetSubscriber();
        //    return sub.Publish(channel, ConvertJson(msg));
        //}

        ///// <summary>
        ///// Redis发布订阅  取消订阅
        ///// </summary>
        ///// <param name="channel"></param>
        //public void Unsubscribe(string channel) {
        //    ISubscriber sub = _conn.GetSubscriber();
        //    sub.Unsubscribe(channel);
        //}

        ///// <summary>
        ///// Redis发布订阅  取消全部订阅
        ///// </summary>
        //public void UnsubscribeAll() {
        //    ISubscriber sub = _conn.GetSubscriber();
        //    sub.UnsubscribeAll();
        //}

        //#endregion 发布订阅
    }
}
