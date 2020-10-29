using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemUsersInMenuProfile
        : AutoMapper.Profile
    {
        public SystemUsersInMenuProfile()
        {
            CreateMap<Master.Data.Entities.SystemUsersInMenu, Master.Domain.Models.SystemUsersInMenuReadModel>();
            CreateMap<Master.Domain.Models.SystemUsersInMenuCreateModel, Master.Data.Entities.SystemUsersInMenu>();
            CreateMap<Master.Data.Entities.SystemUsersInMenu, Master.Domain.Models.SystemUsersInMenuUpdateModel>();
            CreateMap<Master.Domain.Models.SystemUsersInMenuUpdateModel, Master.Data.Entities.SystemUsersInMenu>();
        }

    }
}
