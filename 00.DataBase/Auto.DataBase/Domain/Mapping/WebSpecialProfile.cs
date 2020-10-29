using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebSpecialProfile
        : AutoMapper.Profile
    {
        public WebSpecialProfile()
        {
            CreateMap<Master.Data.Entities.WebSpecial, Master.Domain.Models.WebSpecialReadModel>();
            CreateMap<Master.Domain.Models.WebSpecialCreateModel, Master.Data.Entities.WebSpecial>();
            CreateMap<Master.Data.Entities.WebSpecial, Master.Domain.Models.WebSpecialUpdateModel>();
            CreateMap<Master.Domain.Models.WebSpecialUpdateModel, Master.Data.Entities.WebSpecial>();
        }

    }
}
