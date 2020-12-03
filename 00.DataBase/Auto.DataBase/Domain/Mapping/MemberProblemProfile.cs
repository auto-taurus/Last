using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberProblemProfile
        : AutoMapper.Profile
    {
        public MemberProblemProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberProblem, AutoNews.Domain.Models.MemberProblemReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberProblemCreateModel, AutoNews.Data.Entities.MemberProblem>();
            CreateMap<AutoNews.Data.Entities.MemberProblem, AutoNews.Domain.Models.MemberProblemUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberProblemUpdateModel, AutoNews.Data.Entities.MemberProblem>();
        }

    }
}
