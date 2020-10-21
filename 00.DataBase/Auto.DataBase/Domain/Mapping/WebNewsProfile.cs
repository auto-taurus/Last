using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebNewsProfile
        : AutoMapper.Profile
    {
        public WebNewsProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebNews, AutoNews.Domain.Models.WebNewsReadModel>();
            CreateMap<AutoNews.Domain.Models.WebNewsCreateModel, AutoNews.Data.Entities.WebNews>();
            CreateMap<AutoNews.Data.Entities.WebNews, AutoNews.Domain.Models.WebNewsUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebNewsUpdateModel, AutoNews.Data.Entities.WebNews>();
        }

    }
}
