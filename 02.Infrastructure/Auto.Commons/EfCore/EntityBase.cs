using System;

namespace Auto.Commons.EfCore {
    public class EntityBase : IEntity {
        /// <summary>
        /// 是否启用（-1逻辑删除，0未启用，1已启用）
        /// </summary>
        public int? IsEnable { get; set; }
        /// <summary>
        /// 备注/自定义描述
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        public int? CreateBy { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
