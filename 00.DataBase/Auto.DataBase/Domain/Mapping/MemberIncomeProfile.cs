using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberIncomeProfile
        : AutoMapper.Profile
    {
        public MemberIncomeProfile()
        {
            CreateMap<Master.Data.Entities.MemberIncome, Master.Domain.Models.MemberIncomeReadModel>();
            CreateMap<Master.Domain.Models.MemberIncomeCreateModel, Master.Data.Entities.MemberIncome>();
            CreateMap<Master.Data.Entities.MemberIncome, Master.Domain.Models.MemberIncomeUpdateModel>();
            CreateMap<Master.Domain.Models.MemberIncomeUpdateModel, Master.Data.Entities.MemberIncome>();
        }

    }
}
