using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemDictionaryProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemDictionary, AutoNews.Domain.Models.SystemDictionaryReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemDictionaryCreateModel, AutoNews.Data.Entities.SystemDictionary>();
            CreateMap<AutoNews.Data.Entities.SystemDictionary, AutoNews.Domain.Models.SystemDictionaryUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemDictionaryUpdateModel, AutoNews.Data.Entities.SystemDictionary>();
        }

    }
}
