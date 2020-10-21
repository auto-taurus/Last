using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberCommentProfile
        : AutoMapper.Profile
    {
        public MemberCommentProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberComment, AutoNews.Domain.Models.MemberCommentReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentCreateModel, AutoNews.Data.Entities.MemberComment>();
            CreateMap<AutoNews.Data.Entities.MemberComment, AutoNews.Domain.Models.MemberCommentUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentUpdateModel, AutoNews.Data.Entities.MemberComment>();
        }

    }
}
