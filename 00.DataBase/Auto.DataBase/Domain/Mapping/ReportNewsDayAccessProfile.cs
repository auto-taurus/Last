using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class ReportNewsDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportNewsDayAccessProfile()
        {
            CreateMap<AutoNews.Data.Entities.ReportNewsDayAccess, AutoNews.Domain.Models.ReportNewsDayAccessReadModel>();
            CreateMap<AutoNews.Domain.Models.ReportNewsDayAccessCreateModel, AutoNews.Data.Entities.ReportNewsDayAccess>();
            CreateMap<AutoNews.Data.Entities.ReportNewsDayAccess, AutoNews.Domain.Models.ReportNewsDayAccessUpdateModel>();
            CreateMap<AutoNews.Domain.Models.ReportNewsDayAccessUpdateModel, AutoNews.Data.Entities.ReportNewsDayAccess>();
        }

    }
}
