using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberInfosProfile
        : AutoMapper.Profile
    {
        public MemberInfosProfile()
        {
            CreateMap<Master.Data.Entities.MemberInfos, Master.Domain.Models.MemberInfosReadModel>();
            CreateMap<Master.Domain.Models.MemberInfosCreateModel, Master.Data.Entities.MemberInfos>();
            CreateMap<Master.Data.Entities.MemberInfos, Master.Domain.Models.MemberInfosUpdateModel>();
            CreateMap<Master.Domain.Models.MemberInfosUpdateModel, Master.Data.Entities.MemberInfos>();
        }

    }
}
