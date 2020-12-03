using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemUsersInRoleProfile
        : AutoMapper.Profile
    {
        public SystemUsersInRoleProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemUsersInRole, AutoNews.Domain.Models.SystemUsersInRoleReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersInRoleCreateModel, AutoNews.Data.Entities.SystemUsersInRole>();
            CreateMap<AutoNews.Data.Entities.SystemUsersInRole, AutoNews.Domain.Models.SystemUsersInRoleUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersInRoleUpdateModel, AutoNews.Data.Entities.SystemUsersInRole>();
        }

    }
}
