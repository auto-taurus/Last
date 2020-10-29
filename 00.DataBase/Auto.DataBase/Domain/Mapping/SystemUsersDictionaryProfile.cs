using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemUsersDictionaryProfile
        : AutoMapper.Profile
    {
        public SystemUsersDictionaryProfile()
        {
            CreateMap<Master.Data.Entities.SystemUsersDictionary, Master.Domain.Models.SystemUsersDictionaryReadModel>();
            CreateMap<Master.Domain.Models.SystemUsersDictionaryCreateModel, Master.Data.Entities.SystemUsersDictionary>();
            CreateMap<Master.Data.Entities.SystemUsersDictionary, Master.Domain.Models.SystemUsersDictionaryUpdateModel>();
            CreateMap<Master.Domain.Models.SystemUsersDictionaryUpdateModel, Master.Data.Entities.SystemUsersDictionary>();
        }

    }
}
