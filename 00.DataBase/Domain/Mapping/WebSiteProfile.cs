using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebSiteProfile
        : AutoMapper.Profile
    {
        public WebSiteProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebSite, AutoNews.Domain.Models.WebSiteReadModel>();
            CreateMap<AutoNews.Domain.Models.WebSiteCreateModel, AutoNews.Data.Entities.WebSite>();
            CreateMap<AutoNews.Data.Entities.WebSite, AutoNews.Domain.Models.WebSiteUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebSiteUpdateModel, AutoNews.Data.Entities.WebSite>();
        }

    }
}
