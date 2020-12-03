using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class TaskSignLogProfile
        : AutoMapper.Profile
    {
        public TaskSignLogProfile()
        {
            CreateMap<AutoNews.Data.Entities.TaskSignLog, AutoNews.Domain.Models.TaskSignLogReadModel>();
            CreateMap<AutoNews.Domain.Models.TaskSignLogCreateModel, AutoNews.Data.Entities.TaskSignLog>();
            CreateMap<AutoNews.Data.Entities.TaskSignLog, AutoNews.Domain.Models.TaskSignLogUpdateModel>();
            CreateMap<AutoNews.Domain.Models.TaskSignLogUpdateModel, AutoNews.Data.Entities.TaskSignLog>();
        }

    }
}
