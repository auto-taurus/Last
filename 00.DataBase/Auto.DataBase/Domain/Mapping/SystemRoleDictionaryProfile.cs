using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemRoleDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemRoleDictionaryProfile()
        {
            CreateMap<Master.Data.Entities.SystemRoleDictionary, Master.Domain.Models.SystemRoleDictionaryReadModel>();
            CreateMap<Master.Domain.Models.SystemRoleDictionaryCreateModel, Master.Data.Entities.SystemRoleDictionary>();
            CreateMap<Master.Data.Entities.SystemRoleDictionary, Master.Domain.Models.SystemRoleDictionaryUpdateModel>();
            CreateMap<Master.Domain.Models.SystemRoleDictionaryUpdateModel, Master.Data.Entities.SystemRoleDictionary>();
        }

    }
}
