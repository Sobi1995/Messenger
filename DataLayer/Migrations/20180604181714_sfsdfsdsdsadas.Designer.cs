﻿// <auto-generated />
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Utility;

namespace DataLayer.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20180604181714_sfsdfsdsdsadas")]
    partial class sfsdfsdsdsadas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainClasses.Entity.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactsId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Message");

                    b.Property<int>("Read");

                    b.Property<int>("UserReceiveId");

                    b.Property<int>("UserSendId");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("DomainClasses.Entity.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("NickName");

                    b.Property<string>("Notes");

                    b.Property<int>("User1Id");

                    b.Property<int>("User2Id");

                    b.HasKey("Id");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DomainClasses.Entity.CountryCodes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("code");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("CountryCodes");
                });

            modelBuilder.Entity("DomainClasses.Entity.UserImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Img");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserImg");
                });

            modelBuilder.Entity("Sobhan.DomainClasses.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Sobhan.DomainClasses.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("DisplayName");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<DateTimeOffset?>("LastLoggedIn");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(450);

                    b.Property<int>("Status");

                    b.Property<string>("Username")
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sobhan.DomainClasses.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Sobhan.DomainClasses.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("AccessTokenExpiresDateTime");

                    b.Property<string>("AccessTokenHash");

                    b.Property<DateTimeOffset>("RefreshTokenExpiresDateTime");

                    b.Property<string>("RefreshTokenIdHash")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("RefreshTokenIdHashSource")
                        .HasMaxLength(450);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("DomainClasses.Entity.Chat", b =>
                {
                    b.HasOne("DomainClasses.Entity.Contacts", "Contacts")
                        .WithMany("Chat")
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DomainClasses.Entity.Contacts", b =>
                {
                    b.HasOne("Sobhan.DomainClasses.User", "User1")
                        .WithMany("contacts1")
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Sobhan.DomainClasses.User", "User2")
                        .WithMany("contacts2")
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DomainClasses.Entity.UserImg", b =>
                {
                    b.HasOne("Sobhan.DomainClasses.User", "User")
                        .WithMany("UserImg")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Sobhan.DomainClasses.UserRole", b =>
                {
                    b.HasOne("Sobhan.DomainClasses.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sobhan.DomainClasses.User", "UserIdentity")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sobhan.DomainClasses.UserToken", b =>
                {
                    b.HasOne("Sobhan.DomainClasses.User", "UserIdentity")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
