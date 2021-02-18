using Asa.Draft.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.EF
{
    public class TeacherEntityTypeConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            
            /*
            //Approach two for ReadOnly List
            builder.Property<IEnumerable<Student>>(nameof(Teacher.Students))
                .HasField("_students")
                .UsePropertyAccessMode(PropertyAccessMode.Field);
            */

            builder.HasMany(x => x.Students)
                   .WithOne()
                   .IsRequired();            
        }
    }
}
