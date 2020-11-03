using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberIncomeProfile
        : AutoMapper.Profile
    {
        public MemberIncomeProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberIncome, AutoNews.Domain.Models.MemberIncomeReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberIncomeCreateModel, AutoNews.Data.Entities.MemberIncome>();
            CreateMap<AutoNews.Data.Entities.MemberIncome, AutoNews.Domain.Models.MemberIncomeUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberIncomeUpdateModel, AutoNews.Data.Entities.MemberIncome>();
        }

    }
}
