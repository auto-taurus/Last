using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemRoleProfile
        : AutoMapper.Profile
    {
        public SystemRoleProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemRole, AutoNews.Domain.Models.SystemRoleReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleCreateModel, AutoNews.Data.Entities.SystemRole>();
            CreateMap<AutoNews.Data.Entities.SystemRole, AutoNews.Domain.Models.SystemRoleUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemRoleUpdateModel, AutoNews.Data.Entities.SystemRole>();
        }

    }
}
