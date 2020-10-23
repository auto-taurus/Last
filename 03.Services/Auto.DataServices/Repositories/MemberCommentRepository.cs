using Auto.Commons.Linq;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class MemberCommentRepository : Repository<MemberComment>, IMemberCommentRepository {
        public MemberCommentRepository(NewsContext newsContext) : base(newsContext) {
        }

        public async Task<bool> IncrementUp(int commentId) {
            var flag = await base._BaseDb.Database.ExecuteSqlCommandAsync($"UPDATE Member_Comment SET Up+=1 WHERE CommentId = {commentId}");
            return flag > 0;
        }

        public async Task<bool> IncrementComment(int commentId) {
            var flag = await base._BaseDb.Database.ExecuteSqlCommandAsync($"UPDATE Member_Comment SET Number+=1 WHERE CommentId = {commentId}");
            return flag > 0;
        }
    }
}
