using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemMenuProfile
        : AutoMapper.Profile
    {
        public SystemMenuProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemMenu, AutoNews.Domain.Models.SystemMenuReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemMenuCreateModel, AutoNews.Data.Entities.SystemMenu>();
            CreateMap<AutoNews.Data.Entities.SystemMenu, AutoNews.Domain.Models.SystemMenuUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemMenuUpdateModel, AutoNews.Data.Entities.SystemMenu>();
        }

    }
}
