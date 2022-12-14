// <auto-generated />
using System;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModel.Migrations
{
    [DbContext(typeof(CollegeDbContext))]
    partial class CollegeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModel.Course", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("Code")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);
                
                b.Property<string>("TitleEng")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("TitleFre")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("DescEng")
                    .HasColumnType("nvarchar(4000)")
                    .HasMaxLength(4000);

                b.Property<string>("DescFre")
                    .HasColumnType("nvarchar(4000)")
                    .HasMaxLength(4000);

                b.Property<string>("LangEng")
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                b.Property<string>("LangFre")
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                b.Property<string>("Hours")
                    .HasColumnType("nvarchar(30)")
                    .HasMaxLength(30);

                b.HasKey("Id");

                b.ToTable("Courses");
            });

            modelBuilder.Entity("DataModel.Department", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("NameEng")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("NameFre")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.HasKey("Id");

                b.ToTable("Departments");
            });

            modelBuilder.Entity("DataModel.Discipline", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("NameEng")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("NameFre")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.HasKey("Id");

                b.ToTable("Disciplines");
            });

            modelBuilder.Entity("DataModel.CourseType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("NameEng")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("NameFre")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.HasKey("Id");

                b.ToTable("CourseTypes");
            });

            modelBuilder.Entity("DataModel.Program", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("CodeEng")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                b.Property<string>("CodeFre")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                b.Property<string>("NameEng")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("NameFre")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.HasKey("Id");

                b.ToTable("Programs");
            });

            modelBuilder.Entity("DataModel.YearLevel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Active")
                    .HasColumnType("int");

                b.Property<string>("LevelValue")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);
                
                b.HasKey("Id");

                b.ToTable("YearLevels");
            });

#pragma warning restore 612, 618
        }
    }
}
