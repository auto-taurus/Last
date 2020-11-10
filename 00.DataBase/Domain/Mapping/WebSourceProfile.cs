using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebSourceProfile
        : AutoMapper.Profile
    {
        public WebSourceProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebSource, AutoNews.Domain.Models.WebSourceReadModel>();
            CreateMap<AutoNews.Domain.Models.WebSourceCreateModel, AutoNews.Data.Entities.WebSource>();
            CreateMap<AutoNews.Data.Entities.WebSource, AutoNews.Domain.Models.WebSourceUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebSourceUpdateModel, AutoNews.Data.Entities.WebSource>();
        }

    }
}
