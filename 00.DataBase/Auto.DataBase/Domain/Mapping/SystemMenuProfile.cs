using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemMenuProfile
        : AutoMapper.Profile
    {
        public SystemMenuProfile()
        {
            CreateMap<Master.Data.Entities.SystemMenu, Master.Domain.Models.SystemMenuReadModel>();
            CreateMap<Master.Domain.Models.SystemMenuCreateModel, Master.Data.Entities.SystemMenu>();
            CreateMap<Master.Data.Entities.SystemMenu, Master.Domain.Models.SystemMenuUpdateModel>();
            CreateMap<Master.Domain.Models.SystemMenuUpdateModel, Master.Data.Entities.SystemMenu>();
        }

    }
}
