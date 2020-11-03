using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebSpecialProfile
        : AutoMapper.Profile
    {
        public WebSpecialProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebSpecial, AutoNews.Domain.Models.WebSpecialReadModel>();
            CreateMap<AutoNews.Domain.Models.WebSpecialCreateModel, AutoNews.Data.Entities.WebSpecial>();
            CreateMap<AutoNews.Data.Entities.WebSpecial, AutoNews.Domain.Models.WebSpecialUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebSpecialUpdateModel, AutoNews.Data.Entities.WebSpecial>();
        }

    }
}
