using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebSiteProfile
        : AutoMapper.Profile
    {
        public WebSiteProfile()
        {
            CreateMap<Master.Data.Entities.WebSite, Master.Domain.Models.WebSiteReadModel>();
            CreateMap<Master.Domain.Models.WebSiteCreateModel, Master.Data.Entities.WebSite>();
            CreateMap<Master.Data.Entities.WebSite, Master.Domain.Models.WebSiteUpdateModel>();
            CreateMap<Master.Domain.Models.WebSiteUpdateModel, Master.Data.Entities.WebSite>();
        }

    }
}
