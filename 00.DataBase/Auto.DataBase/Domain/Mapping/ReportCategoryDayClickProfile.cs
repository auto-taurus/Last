using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class ReportCategoryDayClickProfile
        : AutoMapper.Profile
    {
        public ReportCategoryDayClickProfile()
        {
            CreateMap<AutoNews.Data.Entities.ReportCategoryDayClick, AutoNews.Domain.Models.ReportCategoryDayClickReadModel>();
            CreateMap<AutoNews.Domain.Models.ReportCategoryDayClickCreateModel, AutoNews.Data.Entities.ReportCategoryDayClick>();
            CreateMap<AutoNews.Data.Entities.ReportCategoryDayClick, AutoNews.Domain.Models.ReportCategoryDayClickUpdateModel>();
            CreateMap<AutoNews.Domain.Models.ReportCategoryDayClickUpdateModel, AutoNews.Data.Entities.ReportCategoryDayClick>();
        }

    }
}
