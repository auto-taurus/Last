using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberCommentSensitiveProfile
        : AutoMapper.Profile
    {
        public MemberCommentSensitiveProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberCommentSensitive, AutoNews.Domain.Models.MemberCommentSensitiveReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentSensitiveCreateModel, AutoNews.Data.Entities.MemberCommentSensitive>();
            CreateMap<AutoNews.Data.Entities.MemberCommentSensitive, AutoNews.Domain.Models.MemberCommentSensitiveUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberCommentSensitiveUpdateModel, AutoNews.Data.Entities.MemberCommentSensitive>();
        }

    }
}
