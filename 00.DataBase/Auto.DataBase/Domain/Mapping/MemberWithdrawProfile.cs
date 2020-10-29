using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberWithdrawProfile
        : AutoMapper.Profile
    {
        public MemberWithdrawProfile()
        {
            CreateMap<Master.Data.Entities.MemberWithdraw, Master.Domain.Models.MemberWithdrawReadModel>();
            CreateMap<Master.Domain.Models.MemberWithdrawCreateModel, Master.Data.Entities.MemberWithdraw>();
            CreateMap<Master.Data.Entities.MemberWithdraw, Master.Domain.Models.MemberWithdrawUpdateModel>();
            CreateMap<Master.Domain.Models.MemberWithdrawUpdateModel, Master.Data.Entities.MemberWithdraw>();
        }

    }
}
