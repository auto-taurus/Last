using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemUsersProfile
        : AutoMapper.Profile
    {
        public SystemUsersProfile()
        {
            CreateMap<Master.Data.Entities.SystemUsers, Master.Domain.Models.SystemUsersReadModel>();
            CreateMap<Master.Domain.Models.SystemUsersCreateModel, Master.Data.Entities.SystemUsers>();
            CreateMap<Master.Data.Entities.SystemUsers, Master.Domain.Models.SystemUsersUpdateModel>();
            CreateMap<Master.Domain.Models.SystemUsersUpdateModel, Master.Data.Entities.SystemUsers>();
        }

    }
}
