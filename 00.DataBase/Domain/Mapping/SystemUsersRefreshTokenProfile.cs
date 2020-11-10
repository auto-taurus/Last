using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class SystemUsersRefreshTokenProfile
        : AutoMapper.Profile
    {
        public SystemUsersRefreshTokenProfile()
        {
            CreateMap<AutoNews.Data.Entities.SystemUsersRefreshToken, AutoNews.Domain.Models.SystemUsersRefreshTokenReadModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersRefreshTokenCreateModel, AutoNews.Data.Entities.SystemUsersRefreshToken>();
            CreateMap<AutoNews.Data.Entities.SystemUsersRefreshToken, AutoNews.Domain.Models.SystemUsersRefreshTokenUpdateModel>();
            CreateMap<AutoNews.Domain.Models.SystemUsersRefreshTokenUpdateModel, AutoNews.Data.Entities.SystemUsersRefreshToken>();
        }

    }
}
