using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberFansProfile
        : AutoMapper.Profile
    {
        public MemberFansProfile()
        {
            CreateMap<Master.Data.Entities.MemberFans, Master.Domain.Models.MemberFansReadModel>();
            CreateMap<Master.Domain.Models.MemberFansCreateModel, Master.Data.Entities.MemberFans>();
            CreateMap<Master.Data.Entities.MemberFans, Master.Domain.Models.MemberFansUpdateModel>();
            CreateMap<Master.Domain.Models.MemberFansUpdateModel, Master.Data.Entities.MemberFans>();
        }

    }
}
