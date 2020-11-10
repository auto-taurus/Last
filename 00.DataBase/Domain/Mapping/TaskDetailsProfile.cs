using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class TaskDetailsProfile
        : AutoMapper.Profile
    {
        public TaskDetailsProfile()
        {
            CreateMap<AutoNews.Data.Entities.TaskDetails, AutoNews.Domain.Models.TaskDetailsReadModel>();
            CreateMap<AutoNews.Domain.Models.TaskDetailsCreateModel, AutoNews.Data.Entities.TaskDetails>();
            CreateMap<AutoNews.Data.Entities.TaskDetails, AutoNews.Domain.Models.TaskDetailsUpdateModel>();
            CreateMap<AutoNews.Domain.Models.TaskDetailsUpdateModel, AutoNews.Data.Entities.TaskDetails>();
        }

    }
}
