using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemRoleInMenuProfile
        : AutoMapper.Profile
    {
        public SystemRoleInMenuProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemRoleInMenu, AutoNews.Domain.Models.SystemRoleInMenuReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleInMenuCreateModel, AutoNews.Data.Entities.SystemRoleInMenu>();
            CreateMap<AutoNews.Data.Entities.SystemRoleInMenu, AutoNews.Domain.Models.SystemRoleInMenuUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleInMenuUpdateModel, AutoNews.Data.Entities.SystemRoleInMenu>();
        }

    }
}
