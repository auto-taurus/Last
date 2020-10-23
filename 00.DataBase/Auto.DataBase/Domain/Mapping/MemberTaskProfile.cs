using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberTaskProfile
        : AutoMapper.Profile
    {
        public MemberTaskProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberTask, AutoNews.Domain.Models.MemberTaskReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberTaskCreateModel, AutoNews.Data.Entities.MemberTask>();
            CreateMap<AutoNews.Data.Entities.MemberTask, AutoNews.Domain.Models.MemberTaskUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberTaskUpdateModel, AutoNews.Data.Entities.MemberTask>();
        }

    }
}
