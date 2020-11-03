using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberFootprintProfile
        : AutoMapper.Profile
    {
        public MemberFootprintProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberFootprint, AutoNews.Domain.Models.MemberFootprintReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberFootprintCreateModel, AutoNews.Data.Entities.MemberFootprint>();
            CreateMap<AutoNews.Data.Entities.MemberFootprint, AutoNews.Domain.Models.MemberFootprintUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberFootprintUpdateModel, AutoNews.Data.Entities.MemberFootprint>();
        }

    }
}
