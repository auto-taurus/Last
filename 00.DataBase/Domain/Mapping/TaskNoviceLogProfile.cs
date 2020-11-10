using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class TaskNoviceLogProfile
        : AutoMapper.Profile
    {
        public TaskNoviceLogProfile()
        {
            CreateMap<AutoNews.Data.Entities.TaskNoviceLog, AutoNews.Domain.Models.TaskNoviceLogReadModel>();
            CreateMap<AutoNews.Domain.Models.TaskNoviceLogCreateModel, AutoNews.Data.Entities.TaskNoviceLog>();
            CreateMap<AutoNews.Data.Entities.TaskNoviceLog, AutoNews.Domain.Models.TaskNoviceLogUpdateModel>();
            CreateMap<AutoNews.Domain.Models.TaskNoviceLogUpdateModel, AutoNews.Data.Entities.TaskNoviceLog>();
        }

    }
}
