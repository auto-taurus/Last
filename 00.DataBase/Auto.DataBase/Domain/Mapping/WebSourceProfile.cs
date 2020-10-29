using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebSourceProfile
        : AutoMapper.Profile
    {
        public WebSourceProfile()
        {
            CreateMap<Master.Data.Entities.WebSource, Master.Domain.Models.WebSourceReadModel>();
            CreateMap<Master.Domain.Models.WebSourceCreateModel, Master.Data.Entities.WebSource>();
            CreateMap<Master.Data.Entities.WebSource, Master.Domain.Models.WebSourceUpdateModel>();
            CreateMap<Master.Domain.Models.WebSourceUpdateModel, Master.Data.Entities.WebSource>();
        }

    }
}
