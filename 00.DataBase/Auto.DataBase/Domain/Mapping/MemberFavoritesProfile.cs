using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class MemberFavoritesProfile
        : AutoMapper.Profile
    {
        public MemberFavoritesProfile()
        {
            CreateMap<Master.Data.Entities.MemberFavorites, Master.Domain.Models.MemberFavoritesReadModel>();
            CreateMap<Master.Domain.Models.MemberFavoritesCreateModel, Master.Data.Entities.MemberFavorites>();
            CreateMap<Master.Data.Entities.MemberFavorites, Master.Domain.Models.MemberFavoritesUpdateModel>();
            CreateMap<Master.Domain.Models.MemberFavoritesUpdateModel, Master.Data.Entities.MemberFavorites>();
        }

    }
}
