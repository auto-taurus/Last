using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface ISystemDictionaryRepository : IRepository<SystemDictionary>, IScopedInject {
        Task<List<KeyAllDto>> GetAlls(string typeKey);
        Task<List<KeyNameDto>> GetKeyNames(string typeKey);
        Task<List<KeyValueDto>> GetKeyValues(string typeKey);
    }
}
