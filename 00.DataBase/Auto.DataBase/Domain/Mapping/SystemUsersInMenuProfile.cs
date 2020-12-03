using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemUsersInMenuProfile
        : AutoMapper.Profile
    {
        public SystemUsersInMenuProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemUsersInMenu, AutoNews.Domain.Models.SystemUsersInMenuReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersInMenuCreateModel, AutoNews.Data.Entities.SystemUsersInMenu>();
            CreateMap<AutoNews.Data.Entities.SystemUsersInMenu, AutoNews.Domain.Models.SystemUsersInMenuUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersInMenuUpdateModel, AutoNews.Data.Entities.SystemUsersInMenu>();
        }

    }
}
