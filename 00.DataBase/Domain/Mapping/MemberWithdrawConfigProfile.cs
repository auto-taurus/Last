using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberWithdrawConfigProfile
        : AutoMapper.Profile
    {
        public MemberWithdrawConfigProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberWithdrawConfig, AutoNews.Domain.Models.MemberWithdrawConfigReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberWithdrawConfigCreateModel, AutoNews.Data.Entities.MemberWithdrawConfig>();
            CreateMap<AutoNews.Data.Entities.MemberWithdrawConfig, AutoNews.Domain.Models.MemberWithdrawConfigUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberWithdrawConfigUpdateModel, AutoNews.Data.Entities.MemberWithdrawConfig>();
        }

    }
}
