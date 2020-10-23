using Auto.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;

namespace Auto.Configurations.Queries {
    [Export(typeof(IConfigurations))]
    public class CommentAppQuery : IConfigurations {
        public void Configure(ModelBuilder builder) {
            builder.Query<CommentAppDto>(a => {
                a.ToView("CommentAppDto");
            });
        }
    }
}
