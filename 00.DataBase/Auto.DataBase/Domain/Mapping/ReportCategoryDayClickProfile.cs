using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class ReportCategoryDayClickProfile
        : AutoMapper.Profile
    {
        public ReportCategoryDayClickProfile()
        {
            CreateMap<Master.Data.Entities.ReportCategoryDayClick, Master.Domain.Models.ReportCategoryDayClickReadModel>();
            CreateMap<Master.Domain.Models.ReportCategoryDayClickCreateModel, Master.Data.Entities.ReportCategoryDayClick>();
            CreateMap<Master.Data.Entities.ReportCategoryDayClick, Master.Domain.Models.ReportCategoryDayClickUpdateModel>();
            CreateMap<Master.Domain.Models.ReportCategoryDayClickUpdateModel, Master.Data.Entities.ReportCategoryDayClick>();
        }

    }
}
