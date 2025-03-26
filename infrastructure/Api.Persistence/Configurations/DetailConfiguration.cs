using Api.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {

            Faker faker = new("tr");


            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = 1,

            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = true,
                CategoryId = 3,

            };

            Detail detail3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = 4,

            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
