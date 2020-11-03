using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IMemberCommentRepository : IRepository<MemberComment>, IScopedInject {
        /// <summary>
        /// 点赞累加
        /// </summary>
        /// <param name="commentId"></param>
        /// <returns></returns>
        Task<bool> IncrementUp(int commentId);
        /// <summary>
        /// 评论数累加
        /// </summary>
        /// <param name="commentId"></param>
        /// <returns></returns>
        Task<bool> IncrementComment(int commentId);
    }
}
