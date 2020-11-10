using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberInfosProfile
        : AutoMapper.Profile
    {
        public MemberInfosProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberInfos, AutoNews.Domain.Models.MemberInfosReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberInfosCreateModel, AutoNews.Data.Entities.MemberInfos>();
            CreateMap<AutoNews.Data.Entities.MemberInfos, AutoNews.Domain.Models.MemberInfosUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberInfosUpdateModel, AutoNews.Data.Entities.MemberInfos>();
        }

    }
}
