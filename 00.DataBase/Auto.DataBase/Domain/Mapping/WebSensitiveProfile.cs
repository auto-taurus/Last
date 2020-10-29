using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebSensitiveProfile
        : AutoMapper.Profile
    {
        public WebSensitiveProfile()
        {
            CreateMap<Master.Data.Entities.WebSensitive, Master.Domain.Models.WebSensitiveReadModel>();
            CreateMap<Master.Domain.Models.WebSensitiveCreateModel, Master.Data.Entities.WebSensitive>();
            CreateMap<Master.Data.Entities.WebSensitive, Master.Domain.Models.WebSensitiveUpdateModel>();
            CreateMap<Master.Domain.Models.WebSensitiveUpdateModel, Master.Data.Entities.WebSensitive>();
        }

    }
}
