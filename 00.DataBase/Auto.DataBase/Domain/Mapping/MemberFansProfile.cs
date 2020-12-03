using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberFansProfile
        : AutoMapper.Profile
    {
        public MemberFansProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberFans, AutoNews.Domain.Models.MemberFansReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberFansCreateModel, AutoNews.Data.Entities.MemberFans>();
            CreateMap<AutoNews.Data.Entities.MemberFans, AutoNews.Domain.Models.MemberFansUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberFansUpdateModel, AutoNews.Data.Entities.MemberFans>();
        }

    }
}
