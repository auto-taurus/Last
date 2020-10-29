using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemRoleProfile
        : AutoMapper.Profile
    {
        public SystemRoleProfile()
        {
            CreateMap<Master.Data.Entities.SystemRole, Master.Domain.Models.SystemRoleReadModel>();
            CreateMap<Master.Domain.Models.SystemRoleCreateModel, Master.Data.Entities.SystemRole>();
            CreateMap<Master.Data.Entities.SystemRole, Master.Domain.Models.SystemRoleUpdateModel>();
            CreateMap<Master.Domain.Models.SystemRoleUpdateModel, Master.Data.Entities.SystemRole>();
        }

    }
}
