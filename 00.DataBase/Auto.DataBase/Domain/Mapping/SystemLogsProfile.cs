using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemLogsProfile
        : AutoMapper.Profile
    {
        public SystemLogsProfile()
        {
            CreateMap<Master.Data.Entities.SystemLogs, Master.Domain.Models.SystemLogsReadModel>();
            CreateMap<Master.Domain.Models.SystemLogsCreateModel, Master.Data.Entities.SystemLogs>();
            CreateMap<Master.Data.Entities.SystemLogs, Master.Domain.Models.SystemLogsUpdateModel>();
            CreateMap<Master.Domain.Models.SystemLogsUpdateModel, Master.Data.Entities.SystemLogs>();
        }

    }
}
