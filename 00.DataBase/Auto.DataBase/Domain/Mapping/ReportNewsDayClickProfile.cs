using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class ReportNewsDayClickProfile
        : AutoMapper.Profile
    {
        public ReportNewsDayClickProfile()
        {
            CreateMap<AutoNews.Data.Entities.ReportNewsDayClick, AutoNews.Domain.Models.ReportNewsDayClickReadModel>();
            CreateMap<AutoNews.Domain.Models.ReportNewsDayClickCreateModel, AutoNews.Data.Entities.ReportNewsDayClick>();
            CreateMap<AutoNews.Data.Entities.ReportNewsDayClick, AutoNews.Domain.Models.ReportNewsDayClickUpdateModel>();
            CreateMap<AutoNews.Domain.Models.ReportNewsDayClickUpdateModel, AutoNews.Data.Entities.ReportNewsDayClick>();
        }

    }
}
