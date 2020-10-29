using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemRoleInMenuProfile
        : AutoMapper.Profile
    {
        public SystemRoleInMenuProfile()
        {
            CreateMap<Master.Data.Entities.SystemRoleInMenu, Master.Domain.Models.SystemRoleInMenuReadModel>();
            CreateMap<Master.Domain.Models.SystemRoleInMenuCreateModel, Master.Data.Entities.SystemRoleInMenu>();
            CreateMap<Master.Data.Entities.SystemRoleInMenu, Master.Domain.Models.SystemRoleInMenuUpdateModel>();
            CreateMap<Master.Domain.Models.SystemRoleInMenuUpdateModel, Master.Data.Entities.SystemRoleInMenu>();
        }

    }
}
