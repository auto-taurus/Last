using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberCommentSensitiveProfile
        : AutoMapper.Profile
    {
        public MemberCommentSensitiveProfile()
        {
            CreateMap<Master.Data.Entities.MemberCommentSensitive, Master.Domain.Models.MemberCommentSensitiveReadModel>();
            CreateMap<Master.Domain.Models.MemberCommentSensitiveCreateModel, Master.Data.Entities.MemberCommentSensitive>();
            CreateMap<Master.Data.Entities.MemberCommentSensitive, Master.Domain.Models.MemberCommentSensitiveUpdateModel>();
            CreateMap<Master.Domain.Models.MemberCommentSensitiveUpdateModel, Master.Data.Entities.MemberCommentSensitive>();
        }

    }
}
