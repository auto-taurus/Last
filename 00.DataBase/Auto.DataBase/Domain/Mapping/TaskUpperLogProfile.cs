using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class TaskUpperLogProfile
        : AutoMapper.Profile
    {
        public TaskUpperLogProfile()
        {
            CreateMap<AutoNews.Data.Entities.TaskUpperLog, AutoNews.Domain.Models.TaskUpperLogReadModel>();
            CreateMap<AutoNews.Domain.Models.TaskUpperLogCreateModel, AutoNews.Data.Entities.TaskUpperLog>();
            CreateMap<AutoNews.Data.Entities.TaskUpperLog, AutoNews.Domain.Models.TaskUpperLogUpdateModel>();
            CreateMap<AutoNews.Domain.Models.TaskUpperLogUpdateModel, AutoNews.Data.Entities.TaskUpperLog>();
        }

    }
}
