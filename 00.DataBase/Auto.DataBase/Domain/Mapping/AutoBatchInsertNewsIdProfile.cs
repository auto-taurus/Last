using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class AutoBatchInsertNewsIdProfile
        : AutoMapper.Profile
    {
        public AutoBatchInsertNewsIdProfile()
        {
            CreateMap<AutoNews.Data.Entities.AutoBatchInsertNewsId, AutoNews.Domain.Models.AutoBatchInsertNewsIdReadModel>();
            CreateMap<AutoNews.Domain.Models.AutoBatchInsertNewsIdCreateModel, AutoNews.Data.Entities.AutoBatchInsertNewsId>();
            CreateMap<AutoNews.Data.Entities.AutoBatchInsertNewsId, AutoNews.Domain.Models.AutoBatchInsertNewsIdUpdateModel>();
            CreateMap<AutoNews.Domain.Models.AutoBatchInsertNewsIdUpdateModel, AutoNews.Data.Entities.AutoBatchInsertNewsId>();
        }

    }
}
