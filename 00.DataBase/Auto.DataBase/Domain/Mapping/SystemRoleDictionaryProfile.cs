using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemRoleDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemRoleDictionaryProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemRoleDictionary, AutoNews.Domain.Models.SystemRoleDictionaryReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleDictionaryCreateModel, AutoNews.Data.Entities.SystemRoleDictionary>();
            CreateMap<AutoNews.Data.Entities.SystemRoleDictionary, AutoNews.Domain.Models.SystemRoleDictionaryUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleDictionaryUpdateModel, AutoNews.Data.Entities.SystemRoleDictionary>();
        }

    }
}
