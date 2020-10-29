using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberMessageProfile
        : AutoMapper.Profile
    {
        public MemberMessageProfile()
        {
            CreateMap<Master.Data.Entities.MemberMessage, Master.Domain.Models.MemberMessageReadModel>();
            CreateMap<Master.Domain.Models.MemberMessageCreateModel, Master.Data.Entities.MemberMessage>();
            CreateMap<Master.Data.Entities.MemberMessage, Master.Domain.Models.MemberMessageUpdateModel>();
            CreateMap<Master.Domain.Models.MemberMessageUpdateModel, Master.Data.Entities.MemberMessage>();
        }

    }
}
