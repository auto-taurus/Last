using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class TaskInfoProfile
        : AutoMapper.Profile
    {
        public TaskInfoProfile()
        {
            CreateMap<AutoNews.Data.Entities.TaskInfo, AutoNews.Domain.Models.TaskInfoReadModel>();
            CreateMap<AutoNews.Domain.Models.TaskInfoCreateModel, AutoNews.Data.Entities.TaskInfo>();
            CreateMap<AutoNews.Data.Entities.TaskInfo, AutoNews.Domain.Models.TaskInfoUpdateModel>();
            CreateMap<AutoNews.Domain.Models.TaskInfoUpdateModel, AutoNews.Data.Entities.TaskInfo>();
        }

    }
}
