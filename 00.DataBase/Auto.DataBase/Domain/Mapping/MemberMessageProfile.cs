using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberMessageProfile
        : AutoMapper.Profile
    {
        public MemberMessageProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberMessage, AutoNews.Domain.Models.MemberMessageReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberMessageCreateModel, AutoNews.Data.Entities.MemberMessage>();
            CreateMap<AutoNews.Data.Entities.MemberMessage, AutoNews.Domain.Models.MemberMessageUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberMessageUpdateModel, AutoNews.Data.Entities.MemberMessage>();
        }

    }
}
