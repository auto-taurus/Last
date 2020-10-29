using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberCommentProfile
        : AutoMapper.Profile
    {
        public MemberCommentProfile()
        {
            CreateMap<Master.Data.Entities.MemberComment, Master.Domain.Models.MemberCommentReadModel>();
            CreateMap<Master.Domain.Models.MemberCommentCreateModel, Master.Data.Entities.MemberComment>();
            CreateMap<Master.Data.Entities.MemberComment, Master.Domain.Models.MemberCommentUpdateModel>();
            CreateMap<Master.Domain.Models.MemberCommentUpdateModel, Master.Data.Entities.MemberComment>();
        }

    }
}
