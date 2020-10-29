using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebNewsSensitiveProfile
        : AutoMapper.Profile
    {
        public WebNewsSensitiveProfile()
        {
            CreateMap<Master.Data.Entities.WebNewsSensitive, Master.Domain.Models.WebNewsSensitiveReadModel>();
            CreateMap<Master.Domain.Models.WebNewsSensitiveCreateModel, Master.Data.Entities.WebNewsSensitive>();
            CreateMap<Master.Data.Entities.WebNewsSensitive, Master.Domain.Models.WebNewsSensitiveUpdateModel>();
            CreateMap<Master.Domain.Models.WebNewsSensitiveUpdateModel, Master.Data.Entities.WebNewsSensitive>();
        }

    }
}
