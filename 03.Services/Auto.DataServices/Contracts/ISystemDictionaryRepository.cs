using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface ISystemDictionaryRepository : IRepository<SystemDictionary>, ISingletonInject {
        Task<IList<KeyAllDto>> GetAlls(string typeKey);
        Task<IList<KeyNameDto>> GetKeyNames(string typeKey);
        Task<IList<KeyValueDto>> GetKeyValues(string typeKey);
    }
}
