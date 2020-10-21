using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class MemberFavoritesProfile
        : AutoMapper.Profile
    {
        public MemberFavoritesProfile()
        {
            CreateMap<AutoNews.Data.Entities.MemberFavorites, AutoNews.Domain.Models.MemberFavoritesReadModel>();
            CreateMap<AutoNews.Domain.Models.MemberFavoritesCreateModel, AutoNews.Data.Entities.MemberFavorites>();
            CreateMap<AutoNews.Data.Entities.MemberFavorites, AutoNews.Domain.Models.MemberFavoritesUpdateModel>();
            CreateMap<AutoNews.Domain.Models.MemberFavoritesUpdateModel, AutoNews.Data.Entities.MemberFavorites>();
        }

    }
}
