using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class SystemUsersRefreshTokenProfile
        : AutoMapper.Profile
    {
        public SystemUsersRefreshTokenProfile()
        {
            CreateMap<Master.Data.Entities.SystemUsersRefreshToken, Master.Domain.Models.SystemUsersRefreshTokenReadModel>();
            CreateMap<Master.Domain.Models.SystemUsersRefreshTokenCreateModel, Master.Data.Entities.SystemUsersRefreshToken>();
            CreateMap<Master.Data.Entities.SystemUsersRefreshToken, Master.Domain.Models.SystemUsersRefreshTokenUpdateModel>();
            CreateMap<Master.Domain.Models.SystemUsersRefreshTokenUpdateModel, Master.Data.Entities.SystemUsersRefreshToken>();
        }

    }
}
