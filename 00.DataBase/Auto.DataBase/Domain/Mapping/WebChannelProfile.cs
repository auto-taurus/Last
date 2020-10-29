using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebChannelProfile
        : AutoMapper.Profile
    {
        public WebChannelProfile()
        {
            CreateMap<Master.Data.Entities.WebChannel, Master.Domain.Models.WebChannelReadModel>();
            CreateMap<Master.Domain.Models.WebChannelCreateModel, Master.Data.Entities.WebChannel>();
            CreateMap<Master.Data.Entities.WebChannel, Master.Domain.Models.WebChannelUpdateModel>();
            CreateMap<Master.Domain.Models.WebChannelUpdateModel, Master.Data.Entities.WebChannel>();
        }

    }
}
