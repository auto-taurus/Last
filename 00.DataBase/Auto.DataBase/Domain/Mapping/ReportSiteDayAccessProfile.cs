using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class ReportSiteDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportSiteDayAccessProfile()
        {
            CreateMap<Master.Data.Entities.ReportSiteDayAccess, Master.Domain.Models.ReportSiteDayAccessReadModel>();
            CreateMap<Master.Domain.Models.ReportSiteDayAccessCreateModel, Master.Data.Entities.ReportSiteDayAccess>();
            CreateMap<Master.Data.Entities.ReportSiteDayAccess, Master.Domain.Models.ReportSiteDayAccessUpdateModel>();
            CreateMap<Master.Domain.Models.ReportSiteDayAccessUpdateModel, Master.Data.Entities.ReportSiteDayAccess>();
        }

    }
}
