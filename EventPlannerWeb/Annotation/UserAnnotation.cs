﻿// <copyright file="UserAnnotation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DAL.Annotation
{
    using EventPlannerWeb.Models;
    using Microsoft.EntityFrameworkCore;

    internal class UserAnnotation : BaseEntityAnnotation<User>
    {
        internal UserAnnotation(ModelBuilder builder)
            : base(builder)
        {
        }

        public override void Annotate()
        {
            //this.ModelBuilder.HasKey(u => u.UserId);
            //this.ModelBuilder.Property(u => u.UserId).ValueGeneratedOnAdd().UseIdentityColumn(1, 10000).HasColumnName("user_id");
            this.ModelBuilder.Property(u => u.Surname).IsRequired().HasMaxLength(20).HasColumnName("surname");
            this.ModelBuilder.Property(u => u.Name).IsRequired().HasMaxLength(20).HasColumnName("name");
            this.ModelBuilder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(15).HasColumnName("phone_number");
            this.ModelBuilder.Property(u => u.Email).IsRequired().HasMaxLength(40).HasColumnName("email");
            //this.ModelBuilder.Property(u => u.Password).IsRequired().HasMaxLength(200).HasColumnName("password");
            this.ModelBuilder.HasMany(u => u.Events).WithOne(u => u.User).HasForeignKey(u => u.UserId).IsRequired(false);
            this.ModelBuilder.HasMany(u => u.Guests).WithOne(u => u.User).HasForeignKey(u => u.UserId).IsRequired(false);
            this.ModelBuilder.Property(u => u.Gender).IsRequired().HasConversion<string>().HasColumnName("gender");
            this.ModelBuilder.Property(u => u.CreatedDate).IsRequired().HasColumnName("created_date");
            this.ModelBuilder.Property(u => u.ModifiedDate).HasColumnName("modified_date").IsRequired(false);
            this.ModelBuilder.Property(p => p.UserImageName).HasColumnName("user_image").IsRequired(false);
            this.ModelBuilder.HasMany(u => u.UserRoles).WithOne(u => u.User).HasForeignKey(u => u.UserId).IsRequired();
        }
    }
}
