using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebCategoryProfile
        : AutoMapper.Profile
    {
        public WebCategoryProfile()
        {
            CreateMap<Master.Data.Entities.WebCategory, Master.Domain.Models.WebCategoryReadModel>();
            CreateMap<Master.Domain.Models.WebCategoryCreateModel, Master.Data.Entities.WebCategory>();
            CreateMap<Master.Data.Entities.WebCategory, Master.Domain.Models.WebCategoryUpdateModel>();
            CreateMap<Master.Domain.Models.WebCategoryUpdateModel, Master.Data.Entities.WebCategory>();
        }

    }
}
