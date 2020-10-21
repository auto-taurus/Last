using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class MemberInfosRepository : Repository<MemberInfos>, IMemberInfosRepository {
        private readonly NewsContext _Content;
        public MemberInfosRepository(NewsContext newsContext) : base(newsContext) {
            _Content = newsContext;
        }

        public async Task<MemberAppDto> GetAppInfo(int memberId) {
            return await _Content.Query<MemberAppDto>()
                                 .FromSql($"SELECT MemberId,Code,NickName,Name,Sex,Phone,Alipay,Wechat,Avatar,Beans,BeansTotals,IsNew FROM   Member_Infos WHERE MemberId = {memberId} AND IsEnable = 1 ")
                                 .SingleOrDefaultAsync();
        }
    }
}
