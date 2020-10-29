using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class ReportCategoryDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportCategoryDayAccessProfile()
        {
            CreateMap<Master.Data.Entities.ReportCategoryDayAccess, Master.Domain.Models.ReportCategoryDayAccessReadModel>();
            CreateMap<Master.Domain.Models.ReportCategoryDayAccessCreateModel, Master.Data.Entities.ReportCategoryDayAccess>();
            CreateMap<Master.Data.Entities.ReportCategoryDayAccess, Master.Domain.Models.ReportCategoryDayAccessUpdateModel>();
            CreateMap<Master.Domain.Models.ReportCategoryDayAccessUpdateModel, Master.Data.Entities.ReportCategoryDayAccess>();
        }

    }
}
