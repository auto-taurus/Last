using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberCommentUpProfile
        : AutoMapper.Profile
    {
        public MemberCommentUpProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberCommentUp, AutoNews.Domain.Models.MemberCommentUpReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentUpCreateModel, AutoNews.Data.Entities.MemberCommentUp>();
            CreateMap<AutoNews.Data.Entities.MemberCommentUp, AutoNews.Domain.Models.MemberCommentUpUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentUpUpdateModel, AutoNews.Data.Entities.MemberCommentUp>();
        }

    }
}
