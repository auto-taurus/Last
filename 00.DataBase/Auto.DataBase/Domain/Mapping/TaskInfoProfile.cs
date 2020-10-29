using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class TaskInfoProfile
        : AutoMapper.Profile
    {
        public TaskInfoProfile()
        {
            CreateMap<Master.Data.Entities.TaskInfo, Master.Domain.Models.TaskInfoReadModel>();
            CreateMap<Master.Domain.Models.TaskInfoCreateModel, Master.Data.Entities.TaskInfo>();
            CreateMap<Master.Data.Entities.TaskInfo, Master.Domain.Models.TaskInfoUpdateModel>();
            CreateMap<Master.Domain.Models.TaskInfoUpdateModel, Master.Data.Entities.TaskInfo>();
        }

    }
}
