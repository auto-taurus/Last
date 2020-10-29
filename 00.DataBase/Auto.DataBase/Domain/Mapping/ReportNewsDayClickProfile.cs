using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class ReportNewsDayClickProfile
        : AutoMapper.Profile
    {
        public ReportNewsDayClickProfile()
        {
            CreateMap<Master.Data.Entities.ReportNewsDayClick, Master.Domain.Models.ReportNewsDayClickReadModel>();
            CreateMap<Master.Domain.Models.ReportNewsDayClickCreateModel, Master.Data.Entities.ReportNewsDayClick>();
            CreateMap<Master.Data.Entities.ReportNewsDayClick, Master.Domain.Models.ReportNewsDayClickUpdateModel>();
            CreateMap<Master.Domain.Models.ReportNewsDayClickUpdateModel, Master.Data.Entities.ReportNewsDayClick>();
        }

    }
}
