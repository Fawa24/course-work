﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseWork.Migrations
{
    [DbContext(typeof(DishDbContext))]
    [Migration("20240514081011_Delete_Menus_Table")]
    partial class Delete_Menus_Table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Dish", b =>
                {
                    b.Property<Guid>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("dish_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("dish_name");

                    b.Property<int>("DishPrice")
                        .HasColumnType("int")
                        .HasColumnName("dish_price");

                    b.Property<string>("DishType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("dish_type");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit")
                        .HasColumnName("in_stock");

                    b.Property<string>("RestaurantType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("restaurant_type");

                    b.HasKey("DishId")
                        .HasName("PK__Dishes__9F2B4CF9A543A9EF");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Entities.UserQuestion", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("question_id");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("question_text");

                    b.HasKey("QuestionId")
                        .HasName("PK__UserQues__2EC215496477954B");

                    b.ToTable("UserQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}