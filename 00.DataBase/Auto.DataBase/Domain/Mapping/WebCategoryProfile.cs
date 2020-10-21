using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebCategoryProfile
        : AutoMapper.Profile
    {
        public WebCategoryProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebCategory, AutoNews.Domain.Models.WebCategoryReadModel>();
            CreateMap<AutoNews.Domain.Models.WebCategoryCreateModel, AutoNews.Data.Entities.WebCategory>();
            CreateMap<AutoNews.Data.Entities.WebCategory, AutoNews.Domain.Models.WebCategoryUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebCategoryUpdateModel, AutoNews.Data.Entities.WebCategory>();
        }

    }
}
