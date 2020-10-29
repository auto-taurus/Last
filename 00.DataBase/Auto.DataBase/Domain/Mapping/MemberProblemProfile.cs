using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberProblemProfile
        : AutoMapper.Profile
    {
        public MemberProblemProfile()
        {
            CreateMap<Master.Data.Entities.MemberProblem, Master.Domain.Models.MemberProblemReadModel>();
            CreateMap<Master.Domain.Models.MemberProblemCreateModel, Master.Data.Entities.MemberProblem>();
            CreateMap<Master.Data.Entities.MemberProblem, Master.Domain.Models.MemberProblemUpdateModel>();
            CreateMap<Master.Domain.Models.MemberProblemUpdateModel, Master.Data.Entities.MemberProblem>();
        }

    }
}
