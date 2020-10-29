using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemUsersInRoleProfile
        : AutoMapper.Profile
    {
        public SystemUsersInRoleProfile()
        {
            CreateMap<Master.Data.Entities.SystemUsersInRole, Master.Domain.Models.SystemUsersInRoleReadModel>();
            CreateMap<Master.Domain.Models.SystemUsersInRoleCreateModel, Master.Data.Entities.SystemUsersInRole>();
            CreateMap<Master.Data.Entities.SystemUsersInRole, Master.Domain.Models.SystemUsersInRoleUpdateModel>();
            CreateMap<Master.Domain.Models.SystemUsersInRoleUpdateModel, Master.Data.Entities.SystemUsersInRole>();
        }

    }
}
