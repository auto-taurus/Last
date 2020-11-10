using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;

namespace Auto.DataServices.Repositories {
    public class SystemDictionaryRepository : Repository<SystemDictionary>, ISystemDictionaryRepository {
        private readonly NewsContext context;
        public SystemDictionaryRepository(NewsContext newsContext) : base(newsContext) {
            this.context = newsContext;
        }

        public async Task<List<KeyAllDto>> GetAlls(string typeKey) {
            return await base.Query(a => a.TypeKey == typeKey && a.IsEnable == 1, a => a.Sequence)
                             .Select(a => new KeyAllDto {
                                 TypeKey = a.TypeKey,
                                 DistKey = a.DistKey,
                                 DistName = a.DistName,
                                 DistValue = a.DistValue
                             })
                             .ToListAsync();
        }

        public async Task<List<KeyNameDto>> GetKeyNames(string typeKey) {
            return await base.Query(a => a.TypeKey == typeKey && a.IsEnable == 1, a => a.Sequence)
                             .Select(a => new KeyNameDto {
                                 DistKey = a.DistKey,
                                 DistName = a.DistName
                             })
                             .ToListAsync();
        }

        public async Task<List<KeyValueDto>> GetKeyValues(string typeKey) {
            return await base.Query(a => a.TypeKey == typeKey && a.IsEnable == 1, a => a.Sequence)
                             .Select(a => new KeyValueDto {
                                 DistKey = a.DistKey,
                                 DistValue = a.DistValue
                             })
                             .ToListAsync();
        }
    }
}
