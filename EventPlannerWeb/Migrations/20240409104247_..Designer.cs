﻿// <auto-generated />
using System;
using EventPlannerWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EventPlannerWeb.Migrations
{
    [DbContext(typeof(EventPlannerContext))]
    [Migration("20240409104247_.")]
    partial class _
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EventPlannerWeb.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("event_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.EventGuest", b =>
                {
                    b.Property<int>("EventGuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("event_guest_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EventGuestId"));

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<int>("GuestId")
                        .HasColumnType("integer");

                    b.HasKey("EventGuestId");

                    b.HasIndex("EventId");

                    b.HasIndex("GuestId");

                    b.ToTable("EventGuest");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.EventRecipe", b =>
                {
                    b.Property<int>("EventRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("event_recipe_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EventRecipeId"));

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.HasKey("EventRecipeId");

                    b.HasIndex("EventId");

                    b.HasIndex("RecipeId");

                    b.ToTable("EventRecipe");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("guest_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GuestId"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("surname");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("GuestId");

                    b.HasIndex("UserId");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ingredient_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ingredient_recipe_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IngredientRecipeId"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.HasKey("IngredientRecipeId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("recipe_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RecipeId"));

                    b.Property<int>("Calories")
                        .HasColumnType("integer")
                        .HasColumnName("calories");

                    b.Property<int>("CookingTime")
                        .HasColumnType("integer")
                        .HasColumnName("cooking_time");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("RecipeImageName")
                        .HasColumnType("text")
                        .HasColumnName("recipe_image");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 10000)
                        .HasAnnotation("SqlServer:IdentitySeed", 1L)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("surname");

                    b.Property<string>("UserImageName")
                        .HasColumnType("text")
                        .HasColumnName("user_image");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Event", b =>
                {
                    b.HasOne("EventPlannerWeb.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.EventGuest", b =>
                {
                    b.HasOne("EventPlannerWeb.Models.Event", "Event")
                        .WithMany("EventGuests")
                        .HasForeignKey("EventId");

                    b.HasOne("EventPlannerWeb.Models.Guest", "Guest")
                        .WithMany("GuestEvents")
                        .HasForeignKey("GuestId");

                    b.Navigation("Event");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.EventRecipe", b =>
                {
                    b.HasOne("EventPlannerWeb.Models.Event", "Event")
                        .WithMany("EventRecipes")
                        .HasForeignKey("EventId");

                    b.HasOne("EventPlannerWeb.Models.Recipe", "Recipe")
                        .WithMany("RecipeEvents")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Event");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Guest", b =>
                {
                    b.HasOne("EventPlannerWeb.Models.User", "User")
                        .WithMany("Guests")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.IngredientRecipe", b =>
                {
                    b.HasOne("EventPlannerWeb.Models.Ingredient", "Ingredient")
                        .WithMany("RecipesIngerdient")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventPlannerWeb.Models.Recipe", "Recipe")
                        .WithMany("IngredientsRecipe")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Event", b =>
                {
                    b.Navigation("EventGuests");

                    b.Navigation("EventRecipes");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Guest", b =>
                {
                    b.Navigation("GuestEvents");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Ingredient", b =>
                {
                    b.Navigation("RecipesIngerdient");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.Recipe", b =>
                {
                    b.Navigation("IngredientsRecipe");

                    b.Navigation("RecipeEvents");
                });

            modelBuilder.Entity("EventPlannerWeb.Models.User", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Guests");
                });
#pragma warning restore 612, 618
        }
    }
}
