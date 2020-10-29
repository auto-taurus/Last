using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class AutoBatchInsertNewsIdProfile
        : AutoMapper.Profile
    {
        public AutoBatchInsertNewsIdProfile()
        {
            CreateMap<Master.Data.Entities.AutoBatchInsertNewsId, Master.Domain.Models.AutoBatchInsertNewsIdReadModel>();
            CreateMap<Master.Domain.Models.AutoBatchInsertNewsIdCreateModel, Master.Data.Entities.AutoBatchInsertNewsId>();
            CreateMap<Master.Data.Entities.AutoBatchInsertNewsId, Master.Domain.Models.AutoBatchInsertNewsIdUpdateModel>();
            CreateMap<Master.Domain.Models.AutoBatchInsertNewsIdUpdateModel, Master.Data.Entities.AutoBatchInsertNewsId>();
        }

    }
}
