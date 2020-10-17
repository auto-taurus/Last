﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auto.Configurations.Views {
    public class WebSpecialView : IQueryTypeConfiguration<WebSpecialView> {
        public void Configure(QueryTypeBuilder<WebSpecialView> builder) {
            builder.ToView("WebSpecialView");
        }
    }
}
