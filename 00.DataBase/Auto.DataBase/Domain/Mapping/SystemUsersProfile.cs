using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemUsersProfile
        : AutoMapper.Profile
    {
        public SystemUsersProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemUsers, AutoNews.Domain.Models.SystemUsersReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersCreateModel, AutoNews.Data.Entities.SystemUsers>();
            CreateMap<AutoNews.Data.Entities.SystemUsers, AutoNews.Domain.Models.SystemUsersUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersUpdateModel, AutoNews.Data.Entities.SystemUsers>();
        }

    }
}
