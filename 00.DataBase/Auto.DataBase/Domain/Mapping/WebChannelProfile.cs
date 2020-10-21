using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebChannelProfile
        : AutoMapper.Profile
    {
        public WebChannelProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebChannel, AutoNews.Domain.Models.WebChannelReadModel>();
            CreateMap<AutoNews.Domain.Models.WebChannelCreateModel, AutoNews.Data.Entities.WebChannel>();
            CreateMap<AutoNews.Data.Entities.WebChannel, AutoNews.Domain.Models.WebChannelUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebChannelUpdateModel, AutoNews.Data.Entities.WebChannel>();
        }

    }
}
