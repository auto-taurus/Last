using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberFollowProfile
        : AutoMapper.Profile
    {
        public MemberFollowProfile()
        {
            CreateMap<Master.Data.Entities.MemberFollow, Master.Domain.Models.MemberFollowReadModel>();
            CreateMap<Master.Domain.Models.MemberFollowCreateModel, Master.Data.Entities.MemberFollow>();
            CreateMap<Master.Data.Entities.MemberFollow, Master.Domain.Models.MemberFollowUpdateModel>();
            CreateMap<Master.Domain.Models.MemberFollowUpdateModel, Master.Data.Entities.MemberFollow>();
        }

    }
}
