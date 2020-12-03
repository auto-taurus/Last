using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class AppInfoProfile
        : AutoMapper.Profile
    {
        public AppInfoProfile()
        {
            CreateMap<AutoNews.Data.Entities.AppInfo, AutoNews.Domain.Models.AppInfoReadModel>();
            CreateMap<AutoNews.Domain.Models.AppInfoCreateModel, AutoNews.Data.Entities.AppInfo>();
            CreateMap<AutoNews.Data.Entities.AppInfo, AutoNews.Domain.Models.AppInfoUpdateModel>();
            CreateMap<AutoNews.Domain.Models.AppInfoUpdateModel, AutoNews.Data.Entities.AppInfo>();
        }

    }
}
