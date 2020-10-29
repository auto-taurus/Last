using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemDictionaryProfile()
        {
            CreateMap<Master.Data.Entities.SystemDictionary, Master.Domain.Models.SystemDictionaryReadModel>();
            CreateMap<Master.Domain.Models.SystemDictionaryCreateModel, Master.Data.Entities.SystemDictionary>();
            CreateMap<Master.Data.Entities.SystemDictionary, Master.Domain.Models.SystemDictionaryUpdateModel>();
            CreateMap<Master.Domain.Models.SystemDictionaryUpdateModel, Master.Data.Entities.SystemDictionary>();
        }

    }
}
