using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemUsersDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemUsersDictionaryProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemUsersDictionary, AutoNews.Domain.Models.SystemUsersDictionaryReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersDictionaryCreateModel, AutoNews.Data.Entities.SystemUsersDictionary>();
            CreateMap<AutoNews.Data.Entities.SystemUsersDictionary, AutoNews.Domain.Models.SystemUsersDictionaryUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersDictionaryUpdateModel, AutoNews.Data.Entities.SystemUsersDictionary>();
        }

    }
}
