using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class ReportNewsDayAccessProfile
        : AutoMapper.Profile
    {
        public ReportNewsDayAccessProfile()
        {
            CreateMap<Master.Data.Entities.ReportNewsDayAccess, Master.Domain.Models.ReportNewsDayAccessReadModel>();
            CreateMap<Master.Domain.Models.ReportNewsDayAccessCreateModel, Master.Data.Entities.ReportNewsDayAccess>();
            CreateMap<Master.Data.Entities.ReportNewsDayAccess, Master.Domain.Models.ReportNewsDayAccessUpdateModel>();
            CreateMap<Master.Domain.Models.ReportNewsDayAccessUpdateModel, Master.Data.Entities.ReportNewsDayAccess>();
        }

    }
}
