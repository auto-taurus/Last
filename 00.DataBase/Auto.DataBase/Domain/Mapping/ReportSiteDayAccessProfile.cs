using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class ReportSiteDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportSiteDayAccessProfile()
        {
            CreateMap<AutoNews.Data.Entities.ReportSiteDayAccess, AutoNews.Domain.Models.ReportSiteDayAccessReadModel>();
            CreateMap<AutoNews.Domain.Models.ReportSiteDayAccessCreateModel, AutoNews.Data.Entities.ReportSiteDayAccess>();
            CreateMap<AutoNews.Data.Entities.ReportSiteDayAccess, AutoNews.Domain.Models.ReportSiteDayAccessUpdateModel>();
            CreateMap<AutoNews.Domain.Models.ReportSiteDayAccessUpdateModel, AutoNews.Data.Entities.ReportSiteDayAccess>();
        }

    }
}
