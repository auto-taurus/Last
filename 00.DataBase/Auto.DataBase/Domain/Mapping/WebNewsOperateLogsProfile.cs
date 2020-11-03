using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebNewsOperateLogsProfile
        : AutoMapper.Profile
    {
        public WebNewsOperateLogsProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebNewsOperateLogs, AutoNews.Domain.Models.WebNewsOperateLogsReadModel>();
            CreateMap<AutoNews.Domain.Models.WebNewsOperateLogsCreateModel, AutoNews.Data.Entities.WebNewsOperateLogs>();
            CreateMap<AutoNews.Data.Entities.WebNewsOperateLogs, AutoNews.Domain.Models.WebNewsOperateLogsUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebNewsOperateLogsUpdateModel, AutoNews.Data.Entities.WebNewsOperateLogs>();
        }

    }
}
