using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemLogsProfile
        : AutoMapper.Profile
    {
        public SystemLogsProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemLogs, AutoNews.Domain.Models.SystemLogsReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemLogsCreateModel, AutoNews.Data.Entities.SystemLogs>();
            CreateMap<AutoNews.Data.Entities.SystemLogs, AutoNews.Domain.Models.SystemLogsUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemLogsUpdateModel, AutoNews.Data.Entities.SystemLogs>();
        }

    }
}
