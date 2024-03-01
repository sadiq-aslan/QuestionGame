using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Persistence.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.Value).IsRequired().HasMaxLength(50);
            builder.Property(b => b.IsTrue).IsRequired().HasMaxLength(50);

            builder.HasOne(b => b.Question).WithMany(b => b.Answers).HasForeignKey(b => b.QuestionId);
        }
    }
}
