using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberWithdrawConfigProfile
        : AutoMapper.Profile
    {
        public MemberWithdrawConfigProfile()
        {
            CreateMap<Master.Data.Entities.MemberWithdrawConfig, Master.Domain.Models.MemberWithdrawConfigReadModel>();
            CreateMap<Master.Domain.Models.MemberWithdrawConfigCreateModel, Master.Data.Entities.MemberWithdrawConfig>();
            CreateMap<Master.Data.Entities.MemberWithdrawConfig, Master.Domain.Models.MemberWithdrawConfigUpdateModel>();
            CreateMap<Master.Domain.Models.MemberWithdrawConfigUpdateModel, Master.Data.Entities.MemberWithdrawConfig>();
        }

    }
}
