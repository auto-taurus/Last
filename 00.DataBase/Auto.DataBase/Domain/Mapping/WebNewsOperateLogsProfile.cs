using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebNewsOperateLogsProfile
        : AutoMapper.Profile
    {
        public WebNewsOperateLogsProfile()
        {
            CreateMap<Master.Data.Entities.WebNewsOperateLogs, Master.Domain.Models.WebNewsOperateLogsReadModel>();
            CreateMap<Master.Domain.Models.WebNewsOperateLogsCreateModel, Master.Data.Entities.WebNewsOperateLogs>();
            CreateMap<Master.Data.Entities.WebNewsOperateLogs, Master.Domain.Models.WebNewsOperateLogsUpdateModel>();
            CreateMap<Master.Domain.Models.WebNewsOperateLogsUpdateModel, Master.Data.Entities.WebNewsOperateLogs>();
        }

    }
}
