using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberFootprintProfile
        : AutoMapper.Profile
    {
        public MemberFootprintProfile()
        {
            CreateMap<Master.Data.Entities.MemberFootprint, Master.Domain.Models.MemberFootprintReadModel>();
            CreateMap<Master.Domain.Models.MemberFootprintCreateModel, Master.Data.Entities.MemberFootprint>();
            CreateMap<Master.Data.Entities.MemberFootprint, Master.Domain.Models.MemberFootprintUpdateModel>();
            CreateMap<Master.Domain.Models.MemberFootprintUpdateModel, Master.Data.Entities.MemberFootprint>();
        }

    }
}
