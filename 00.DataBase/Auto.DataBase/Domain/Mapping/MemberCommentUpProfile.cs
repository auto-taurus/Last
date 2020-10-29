using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberCommentUpProfile
        : AutoMapper.Profile
    {
        public MemberCommentUpProfile()
        {
            CreateMap<Master.Data.Entities.MemberCommentUp, Master.Domain.Models.MemberCommentUpReadModel>();
            CreateMap<Master.Domain.Models.MemberCommentUpCreateModel, Master.Data.Entities.MemberCommentUp>();
            CreateMap<Master.Data.Entities.MemberCommentUp, Master.Domain.Models.MemberCommentUpUpdateModel>();
            CreateMap<Master.Domain.Models.MemberCommentUpUpdateModel, Master.Data.Entities.MemberCommentUp>();
        }

    }
}
