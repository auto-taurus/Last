using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberFollowProfile
        : AutoMapper.Profile
    {
        public MemberFollowProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberFollow, AutoNews.Domain.Models.MemberFollowReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberFollowCreateModel, AutoNews.Data.Entities.MemberFollow>();
            CreateMap<AutoNews.Data.Entities.MemberFollow, AutoNews.Domain.Models.MemberFollowUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberFollowUpdateModel, AutoNews.Data.Entities.MemberFollow>();
        }

    }
}
