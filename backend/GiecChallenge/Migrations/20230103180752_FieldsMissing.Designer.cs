﻿// <auto-generated />
using System;
using GiecChallenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GiecChallenge.Migrations
{
    [DbContext(typeof(GiecChallengeContext))]
    [Migration("20230103180752_FieldsMissing")]
    partial class FieldsMissing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GiecChallenge.Models.CarbonLoan", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("dateBegin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("dateEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("productid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.HasIndex("userid");

                    b.ToTable("CarbonLoans");
                });

            modelBuilder.Entity("GiecChallenge.Models.Currency", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ISOCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("GiecChallenge.Models.CurrencyLanguage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("currencyid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("languageid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("currencyid");

                    b.HasIndex("languageid");

                    b.ToTable("CurrencyLanguages");
                });

            modelBuilder.Entity("GiecChallenge.Models.Language", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ISOCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("GiecChallenge.Models.LanguageLanguage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("names")
                        .HasColumnType("uuid");

                    b.Property<Guid>("usedToTranlateLanguage")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("names");

                    b.HasIndex("usedToTranlateLanguage");

                    b.ToTable("LanguageLanguages");
                });

            modelBuilder.Entity("GiecChallenge.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("CO2")
                        .HasColumnType("double precision");

                    b.Property<string>("CO2Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("amortization")
                        .HasColumnType("integer");

                    b.Property<Guid>("subgroupid")
                        .HasColumnType("uuid");

                    b.Property<double>("water")
                        .HasColumnType("double precision");

                    b.Property<string>("waterUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("subgroupid");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductGroup", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductGroupLanguage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("languageid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("productgroupid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("languageid");

                    b.HasIndex("productgroupid");

                    b.ToTable("ProductGroupLanguages");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductLanguage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Productid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("languageid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.HasIndex("languageid");

                    b.ToTable("ProductLanguages");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductPurchase", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("currencyid")
                        .HasColumnType("uuid");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<Guid>("productid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("purchaseid")
                        .HasColumnType("uuid");

                    b.Property<double>("quantity")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.HasIndex("currencyid");

                    b.HasIndex("productid");

                    b.HasIndex("purchaseid");

                    b.ToTable("ProductPurchases");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductSubGroup", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Groupeid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("Groupeid");

                    b.ToTable("ProductSubGroups");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductSubGroupLanguage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProductSubGroupid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("languageid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("ProductSubGroupid");

                    b.HasIndex("languageid");

                    b.ToTable("ProductSubGroupLanguages");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductUserTranslation", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("productid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.HasIndex("userid");

                    b.ToTable("ProductUserTranslations");
                });

            modelBuilder.Entity("GiecChallenge.Models.Purchase", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("datePurchase")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("GiecChallenge.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("creationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("favoriteLanguageid")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("hash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("favoriteLanguageid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GiecChallenge.Models.UserGroup", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("GiecChallenge.Models.UserInGroup", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("userGroupid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("userGroupid");

                    b.HasIndex("userid");

                    b.ToTable("UserInGroup");
                });

            modelBuilder.Entity("GiecChallenge.Models.Aliment", b =>
                {
                    b.HasBaseType("GiecChallenge.Models.Product");

                    b.Property<string>("ciqual")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Aliment");
                });

            modelBuilder.Entity("GiecChallenge.Models.CarbonLoan", b =>
                {
                    b.HasOne("GiecChallenge.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GiecChallenge.Models.CurrencyLanguage", b =>
                {
                    b.HasOne("GiecChallenge.Models.Currency", "currency")
                        .WithMany("names")
                        .HasForeignKey("currencyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("language");
                });

            modelBuilder.Entity("GiecChallenge.Models.LanguageLanguage", b =>
                {
                    b.HasOne("GiecChallenge.Models.Language", "languageToChange")
                        .WithMany("names")
                        .HasForeignKey("names")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.Language", "language")
                        .WithMany("usedToTranlateLanguage")
                        .HasForeignKey("usedToTranlateLanguage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");

                    b.Navigation("languageToChange");
                });

            modelBuilder.Entity("GiecChallenge.Models.Product", b =>
                {
                    b.HasOne("GiecChallenge.Models.ProductSubGroup", "subgroup")
                        .WithMany()
                        .HasForeignKey("subgroupid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subgroup");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductGroupLanguage", b =>
                {
                    b.HasOne("GiecChallenge.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.ProductGroup", "productgroup")
                        .WithMany("names")
                        .HasForeignKey("productgroupid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");

                    b.Navigation("productgroup");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductLanguage", b =>
                {
                    b.HasOne("GiecChallenge.Models.Product", null)
                        .WithMany("names")
                        .HasForeignKey("Productid");

                    b.HasOne("GiecChallenge.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductPurchase", b =>
                {
                    b.HasOne("GiecChallenge.Models.Currency", "currency")
                        .WithMany()
                        .HasForeignKey("currencyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.Purchase", "purchase")
                        .WithMany("products")
                        .HasForeignKey("purchaseid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("product");

                    b.Navigation("purchase");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductSubGroup", b =>
                {
                    b.HasOne("GiecChallenge.Models.ProductGroup", "Groupe")
                        .WithMany()
                        .HasForeignKey("Groupeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groupe");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductSubGroupLanguage", b =>
                {
                    b.HasOne("GiecChallenge.Models.ProductSubGroup", null)
                        .WithMany("names")
                        .HasForeignKey("ProductSubGroupid");

                    b.HasOne("GiecChallenge.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductUserTranslation", b =>
                {
                    b.HasOne("GiecChallenge.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GiecChallenge.Models.Purchase", b =>
                {
                    b.HasOne("GiecChallenge.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("GiecChallenge.Models.User", b =>
                {
                    b.HasOne("GiecChallenge.Models.Language", "favoriteLanguage")
                        .WithMany()
                        .HasForeignKey("favoriteLanguageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("favoriteLanguage");
                });

            modelBuilder.Entity("GiecChallenge.Models.UserInGroup", b =>
                {
                    b.HasOne("GiecChallenge.Models.UserGroup", "userGroup")
                        .WithMany()
                        .HasForeignKey("userGroupid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiecChallenge.Models.User", "user")
                        .WithMany("groups")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");

                    b.Navigation("userGroup");
                });

            modelBuilder.Entity("GiecChallenge.Models.Currency", b =>
                {
                    b.Navigation("names");
                });

            modelBuilder.Entity("GiecChallenge.Models.Language", b =>
                {
                    b.Navigation("names");

                    b.Navigation("usedToTranlateLanguage");
                });

            modelBuilder.Entity("GiecChallenge.Models.Product", b =>
                {
                    b.Navigation("names");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductGroup", b =>
                {
                    b.Navigation("names");
                });

            modelBuilder.Entity("GiecChallenge.Models.ProductSubGroup", b =>
                {
                    b.Navigation("names");
                });

            modelBuilder.Entity("GiecChallenge.Models.Purchase", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("GiecChallenge.Models.User", b =>
                {
                    b.Navigation("groups");
                });
#pragma warning restore 612, 618
        }
    }
}
