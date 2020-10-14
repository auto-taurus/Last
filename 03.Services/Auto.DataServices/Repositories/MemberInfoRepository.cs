using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;

namespace Auto.DataServices.Repositories {
    public class MemberInfoRepository : Repository<MemberInfo>, IMemberInfoRepository {
        public MemberInfoRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }

    }
}
