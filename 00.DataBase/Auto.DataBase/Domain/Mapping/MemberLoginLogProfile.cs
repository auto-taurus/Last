using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberLoginLogProfile
        : AutoMapper.Profile
    {
        public MemberLoginLogProfile()
        {
            CreateMap<Master.Data.Entities.MemberLoginLog, Master.Domain.Models.MemberLoginLogReadModel>();
            CreateMap<Master.Domain.Models.MemberLoginLogCreateModel, Master.Data.Entities.MemberLoginLog>();
            CreateMap<Master.Data.Entities.MemberLoginLog, Master.Domain.Models.MemberLoginLogUpdateModel>();
            CreateMap<Master.Domain.Models.MemberLoginLogUpdateModel, Master.Data.Entities.MemberLoginLog>();
        }

    }
}
