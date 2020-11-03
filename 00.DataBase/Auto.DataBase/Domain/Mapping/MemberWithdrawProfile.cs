using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberWithdrawProfile
        : AutoMapper.Profile
    {
        public MemberWithdrawProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberWithdraw, AutoNews.Domain.Models.MemberWithdrawReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberWithdrawCreateModel, AutoNews.Data.Entities.MemberWithdraw>();
            CreateMap<AutoNews.Data.Entities.MemberWithdraw, AutoNews.Domain.Models.MemberWithdrawUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberWithdrawUpdateModel, AutoNews.Data.Entities.MemberWithdraw>();
        }

    }
}
