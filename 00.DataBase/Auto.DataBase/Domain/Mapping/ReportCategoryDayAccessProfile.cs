using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class ReportCategoryDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportCategoryDayAccessProfile()
        {
            CreateMap<AutoNews.Data.Entities.ReportCategoryDayAccess, AutoNews.Domain.Models.ReportCategoryDayAccessReadModel>();
            CreateMap<AutoNews.Domain.Models.ReportCategoryDayAccessCreateModel, AutoNews.Data.Entities.ReportCategoryDayAccess>();
            CreateMap<AutoNews.Data.Entities.ReportCategoryDayAccess, AutoNews.Domain.Models.ReportCategoryDayAccessUpdateModel>();
            CreateMap<AutoNews.Domain.Models.ReportCategoryDayAccessUpdateModel, AutoNews.Data.Entities.ReportCategoryDayAccess>();
        }

    }
}
