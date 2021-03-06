﻿using Lyra.Model;
using Lyra.WebAPI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public partial class LyraContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Salt.Add(HashHelper.GenerateSalt());
            }

            modelBuilder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        ID = 1,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "desktop",
                        Email = "desktop@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[0],
                        PasswordHash = HashHelper.GenerateHash(Salt[0], "test"),
                    },
                    new User
                    {
                        ID = 2,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "Admin",
                        Email = "admin@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[1],
                        PasswordHash = HashHelper.GenerateHash(Salt[1], "test"),
                    },
                    new User
                    {
                        ID = 3,
                        FirstName = "Mobile",
                        LastName = "User",
                        Username = "mobile",
                        Email = "mobile@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[2],
                        PasswordHash = HashHelper.GenerateHash(Salt[2], "test"),
                    },
                    new User
                    {
                        ID = 4,
                        FirstName = "User1",
                        LastName = "User1",
                        Username = "User1",
                        Email = "user1@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[3],
                        PasswordHash = HashHelper.GenerateHash(Salt[3], "test"),
                    },
                    new User
                    {
                        ID = 5,
                        FirstName = "User2",
                        LastName = "User2",
                        Username = "User2",
                        Email = "user2@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[4],
                        PasswordHash = HashHelper.GenerateHash(Salt[4], "test"),
                    },
                    new User
                    {
                        ID = 6,
                        FirstName = "User3",
                        LastName = "User3",
                        Username = "User3",
                        Email = "user3@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[5],
                        PasswordHash = HashHelper.GenerateHash(Salt[5], "test"),
                    },
                    new User
                    {
                        ID = 7,
                        FirstName = "User4",
                        LastName = "User4",
                        Username = "User4",
                        Email = "user4@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[6],
                        PasswordHash = HashHelper.GenerateHash(Salt[6], "test"),
                    },
                    new User
                    {
                        ID = 8,
                        FirstName = "User5",
                        LastName = "User5",
                        Username = "User5",
                        Email = "user5@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[7],
                        PasswordHash = HashHelper.GenerateHash(Salt[7], "test"),
                    },
                    new User
                    {
                        ID = 9,
                        FirstName = "User6",
                        LastName = "User6",
                        Username = "User6",
                        Email = "user6@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[8],
                        PasswordHash = HashHelper.GenerateHash(Salt[8], "test"),
                    },
                    new User
                    {
                        ID = 10,
                        FirstName = "User7",
                        LastName = "User7",
                        Username = "User7",
                        Email = "user7@lyra.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[9],
                        PasswordHash = HashHelper.GenerateHash(Salt[9], "test"),
                    }
                );


            modelBuilder.Entity<Role>()
                .HasData
                (
                    new Role { ID = 1, Name = "Administrator" },
                    new Role { ID = 2, Name = "User" }
                );

            modelBuilder.Entity<UserRole>()
                .HasData
                (
                    new UserRole { UserID = 1, RoleID = 1 },
                    new UserRole { UserID = 2, RoleID = 1 },
                    new UserRole { UserID = 3, RoleID = 2 },
                    new UserRole { UserID = 4, RoleID = 2 },
                    new UserRole { UserID = 5, RoleID = 2 },
                    new UserRole { UserID = 6, RoleID = 2 },
                    new UserRole { UserID = 7, RoleID = 2 },
                    new UserRole { UserID = 8, RoleID = 2 },
                    new UserRole { UserID = 9, RoleID = 2 },
                    new UserRole { UserID = 10, RoleID = 2 }
                );

            modelBuilder.Entity<Artist>()
                .HasData
                (
                    new Artist
                    {
                        ID = 1,
                        Name = "Gorillaz",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Artists/gorillaz.jpg")
                    },
                    new Artist
                    {
                        ID = 2,
                        Name = "Audioslave",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Artists/audioslave.jpg")
                    },
                    new Artist
                    {
                        ID = 3,
                        Name = "Gojira",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Artists/gojira.jpg")
                    }
                );

            modelBuilder.Entity<Album>()
                .HasData
                (
                    new Album
                    {
                        ID = 1,
                        Name = "Gorillaz",
                        ReleaseYear = 2001,
                        Image = FileHelper.ReadFile("SeedFiles/Images/Albums/gorillaz.jpg"),
                        ArtistID = 1,
                    },
                    new Album
                    {
                        ID = 2,
                        Name = "Demon Days",
                        ReleaseYear = 2003,
                        Image = FileHelper.ReadFile("SeedFiles/Images/Albums/demon_days.jpg"),
                        ArtistID = 1
                    },
                    new Album
                    {
                        ID = 3,
                        Name = "Audioslave",
                        ReleaseYear = 2002,
                        Image = FileHelper.ReadFile("SeedFiles/Images/Albums/audioslave.jpg"),
                        ArtistID = 2
                    },
                    new Album
                    {
                        ID = 4,
                        Name = "From Mars To Sirius",
                        ReleaseYear = 2006,
                        Image = FileHelper.ReadFile("SeedFiles/Images/Albums/from_mars_to_sirius.jpg"),
                        ArtistID = 3
                    }
                );
            modelBuilder.Entity<Track>()
                .HasData
                (
                    new Track
                    {
                        ID = 1,
                        Length = new TimeSpan(0, 3, 32),
                        Name = "Re-Hash"
                    },
                    new Track
                    {
                        ID = 2,
                        Length = new TimeSpan(0, 2, 35),
                        Name = "5/4"
                    },
                    new Track
                    {
                        ID = 3,
                        Length = new TimeSpan(0, 3, 7),
                        Name = "Tomorrow Comes Today"
                    },
                    new Track
                    {
                        ID = 4,
                        Length = new TimeSpan(0, 3, 51),
                        Name = "New Genious (Brother)"
                    },
                    new Track
                    {
                        ID = 5,
                        Length = new TimeSpan(0, 5, 32),
                        Name = "Clint Eastwood"
                    },
                    new Track
                    {
                        ID = 6,
                        Length = new TimeSpan(0, 4, 22),
                        Name = "Man Research (Clapper)"
                    },
                    new Track
                    {
                        ID = 7,
                        Length = new TimeSpan(0, 1, 33),
                        Name = "Punk"
                    },
                    new Track
                    {
                        ID = 8,
                        Length = new TimeSpan(0, 4, 32),
                        Name = "Sound Check (Gravity)"
                    },
                    new Track
                    {
                        ID = 9,
                        Length = new TimeSpan(0, 4, 36),
                        Name = "Double Bass"
                    },
                    new Track
                    {
                        ID = 10,
                        Length = new TimeSpan(0, 4, 1),
                        Name = "Rock The House"
                    },
                    new Track
                    {
                        ID = 11,
                        Length = new TimeSpan(0, 3, 21),
                        Name = "19-2000"
                    },
                    new Track
                    {
                        ID = 12,
                        Length = new TimeSpan(0, 3, 30),
                        Name = "Latin Simone (Que Pasa Contigo)"
                    },
                    new Track
                    {
                        ID = 13,
                        Length = new TimeSpan(0, 3, 25),
                        Name = "Starshine"
                    },
                    new Track
                    {
                        ID = 14,
                        Length = new TimeSpan(0, 3, 29),
                        Name = "Slow Country"
                    },
                    new Track
                    {
                        ID = 15,
                        Length = new TimeSpan(0, 10, 21),
                        Name = "M1 A1"
                    },

                    new Track
                    {
                        ID = 16,
                        Length = new TimeSpan(0, 1, 1),
                        Name = "Intro"
                    },
                    new Track
                    {
                        ID = 17,
                        Length = new TimeSpan(0, 3, 4),
                        Name = "Last Living Soul"
                    },
                    new Track
                    {
                        ID = 18,
                        Length = new TimeSpan(0, 3, 39),
                        Name = "Kids With Guns"
                    },
                    new Track
                    {
                        ID = 19,
                        Length = new TimeSpan(0, 4, 24),
                        Name = "O Green World"
                    },
                    new Track
                    {
                        ID = 20,
                        Length = new TimeSpan(0, 3, 37),
                        Name = "Dirty Harry"
                    },
                    new Track
                    {
                        ID = 21,
                        Length = new TimeSpan(0, 3, 34),
                        Name = "Feel Good Inc."
                    },
                    new Track
                    {
                        ID = 22,
                        Length = new TimeSpan(0, 3, 43),
                        Name = "El Manana"
                    },
                    new Track
                    {
                        ID = 23,
                        Length = new TimeSpan(0, 4, 44),
                        Name = "Every Planet We Reach Is Dead"
                    },
                    new Track
                    {
                        ID = 24,
                        Length = new TimeSpan(0, 2, 36),
                        Name = "November Has Come"
                    },
                    new Track
                    {
                        ID = 25,
                        Length = new TimeSpan(0, 3, 23),
                        Name = "All Alone"
                    },
                    new Track
                    {
                        ID = 26,
                        Length = new TimeSpan(0, 2, 4),
                        Name = "White Light"
                    },
                    new Track
                    {
                        ID = 27,
                        Length = new TimeSpan(0, 3, 57),
                        Name = "DARE"
                    },
                    new Track
                    {
                        ID = 28,
                        Length = new TimeSpan(0, 3, 10),
                        Name = "Fire Comming Out Of The Monkeys Head"
                    },
                    new Track
                    {
                        ID = 29,
                        Length = new TimeSpan(0, 1, 56),
                        Name = "Don't Get Lost In Heaven"
                    },
                    new Track
                    {
                        ID = 30,
                        Length = new TimeSpan(0, 4, 21),
                        Name = "Demon Days"
                    },

                    new Track
                    {
                        ID = 31,
                        Length = new TimeSpan(0, 3, 42),
                        Name = "Cochise"
                    },
                    new Track
                    {
                        ID = 32,
                        Length = new TimeSpan(0, 4, 37),
                        Name = "Show Me How to Live"
                    },
                    new Track
                    {
                        ID = 33,
                        Length = new TimeSpan(0, 4, 39),
                        Name = "Gasoline"
                    },
                    new Track
                    {
                        ID = 34,
                        Length = new TimeSpan(0, 4, 9),
                        Name = "What You Are"
                    },
                    new Track
                    {
                        ID = 35,
                        Length = new TimeSpan(0, 4, 54),
                        Name = "Like A Stone"
                    },
                    new Track
                    {
                        ID = 36,
                        Length = new TimeSpan(0, 4, 23),
                        Name = "Set It Off"
                    },
                    new Track
                    {
                        ID = 37,
                        Length = new TimeSpan(0, 5, 43),
                        Name = "Shadow Of The Sun"
                    },
                    new Track
                    {
                        ID = 38,
                        Length = new TimeSpan(0, 5, 34),
                        Name = "I Am The Highway"
                    },
                    new Track
                    {
                        ID = 39,
                        Length = new TimeSpan(0, 3, 26),
                        Name = "Exploder"
                    },
                    new Track
                    {
                        ID = 40,
                        Length = new TimeSpan(0, 3, 26),
                        Name = "Hyptonize"
                    },
                    new Track
                    {
                        ID = 41,
                        Length = new TimeSpan(0, 5, 3),
                        Name = "Light My Way"
                    },
                    new Track
                    {
                        ID = 42,
                        Length = new TimeSpan(0, 4, 59),
                        Name = "Getaway Car"
                    },
                    new Track
                    {
                        ID = 43,
                        Length = new TimeSpan(0, 5, 17),
                        Name = "The Last Remaining Light"
                    },
                    new Track
                    {
                        ID = 44,
                        Length = new TimeSpan(0, 4, 0),
                        Name = "Give"
                    },

                    new Track { ID = 45, Length = new TimeSpan(0, 5, 32), Name = "Ocean Planet" },
                    new Track { ID = 46, Length = new TimeSpan(0, 4, 18), Name = "Backbone" },
                    new Track { ID = 47, Length = new TimeSpan(0, 5, 48), Name = "From The Sky" },
                    new Track { ID = 48, Length = new TimeSpan(0, 2, 9), Name = "Unicorn" },
                    new Track { ID = 49, Length = new TimeSpan(0, 6, 54), Name = "Where Dragons Dwell" },
                    new Track { ID = 50, Length = new TimeSpan(0, 3, 57), Name = "The Heaviest Matter Of The Universe" },
                    new Track { ID = 51, Length = new TimeSpan(0, 7, 44), Name = "Flying Whales" },
                    new Track { ID = 52, Length = new TimeSpan(0, 7, 47), Name = "In The Wilderness" },
                    new Track { ID = 53, Length = new TimeSpan(0, 6, 52), Name = "World To Come" },
                    new Track { ID = 54, Length = new TimeSpan(0, 2, 24), Name = "From Mars" },
                    new Track { ID = 55, Length = new TimeSpan(0, 5, 37), Name = "To Sirius" },
                    new Track { ID = 56, Length = new TimeSpan(0, 7, 50), Name = "Global Warming" }
                );

            modelBuilder.Entity<TrackArtist>()
                .HasData
                (
                    new TrackArtist { ArtistID = 1, TrackID = 1, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 2, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 3, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 4, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 5, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 6, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 7, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 8, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 9, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 10, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 11, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 12, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 13, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 14, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 15, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 1, TrackID = 16, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 17, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 18, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 19, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 20, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 21, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 22, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 23, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 24, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 25, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 26, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 27, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 28, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 29, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 30, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 2, TrackID = 31, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 32, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 33, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 34, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 35, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 36, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 37, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 38, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 39, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 40, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 41, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 42, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 43, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 44, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 3, TrackID = 46, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 47, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 48, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 49, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 50, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 51, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 52, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 53, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 54, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 55, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 56, TrackArtistRole = TrackArtistRole.Main }
                );


            modelBuilder.Entity<AlbumTrack>()
                .HasData
                (
                    new AlbumTrack { AlbumID = 1, TrackID = 1 },
                    new AlbumTrack { AlbumID = 1, TrackID = 2 },
                    new AlbumTrack { AlbumID = 1, TrackID = 3 },
                    new AlbumTrack { AlbumID = 1, TrackID = 4 },
                    new AlbumTrack { AlbumID = 1, TrackID = 5 },
                    new AlbumTrack { AlbumID = 1, TrackID = 6 },
                    new AlbumTrack { AlbumID = 1, TrackID = 7 },
                    new AlbumTrack { AlbumID = 1, TrackID = 8 },
                    new AlbumTrack { AlbumID = 1, TrackID = 9 },
                    new AlbumTrack { AlbumID = 1, TrackID = 10 },
                    new AlbumTrack { AlbumID = 1, TrackID = 11 },
                    new AlbumTrack { AlbumID = 1, TrackID = 12 },
                    new AlbumTrack { AlbumID = 1, TrackID = 13 },
                    new AlbumTrack { AlbumID = 1, TrackID = 14 },
                    new AlbumTrack { AlbumID = 1, TrackID = 15 },

                    new AlbumTrack { AlbumID = 2, TrackID = 16 },
                    new AlbumTrack { AlbumID = 2, TrackID = 17 },
                    new AlbumTrack { AlbumID = 2, TrackID = 18 },
                    new AlbumTrack { AlbumID = 2, TrackID = 19 },
                    new AlbumTrack { AlbumID = 2, TrackID = 20 },
                    new AlbumTrack { AlbumID = 2, TrackID = 21 },
                    new AlbumTrack { AlbumID = 2, TrackID = 22 },
                    new AlbumTrack { AlbumID = 2, TrackID = 23 },
                    new AlbumTrack { AlbumID = 2, TrackID = 24 },
                    new AlbumTrack { AlbumID = 2, TrackID = 25 },
                    new AlbumTrack { AlbumID = 2, TrackID = 26 },
                    new AlbumTrack { AlbumID = 2, TrackID = 27 },
                    new AlbumTrack { AlbumID = 2, TrackID = 28 },
                    new AlbumTrack { AlbumID = 2, TrackID = 29 },
                    new AlbumTrack { AlbumID = 2, TrackID = 30 },

                    new AlbumTrack { AlbumID = 3, TrackID = 31 },
                    new AlbumTrack { AlbumID = 3, TrackID = 32 },
                    new AlbumTrack { AlbumID = 3, TrackID = 33 },
                    new AlbumTrack { AlbumID = 3, TrackID = 34 },
                    new AlbumTrack { AlbumID = 3, TrackID = 35 },
                    new AlbumTrack { AlbumID = 3, TrackID = 36 },
                    new AlbumTrack { AlbumID = 3, TrackID = 37 },
                    new AlbumTrack { AlbumID = 3, TrackID = 38 },
                    new AlbumTrack { AlbumID = 3, TrackID = 39 },
                    new AlbumTrack { AlbumID = 3, TrackID = 40 },
                    new AlbumTrack { AlbumID = 3, TrackID = 41 },
                    new AlbumTrack { AlbumID = 3, TrackID = 42 },
                    new AlbumTrack { AlbumID = 3, TrackID = 43 },
                    new AlbumTrack { AlbumID = 3, TrackID = 44 },

                    new AlbumTrack { AlbumID = 4, TrackID = 45 },
                    new AlbumTrack { AlbumID = 4, TrackID = 46 },
                    new AlbumTrack { AlbumID = 4, TrackID = 47 },
                    new AlbumTrack { AlbumID = 4, TrackID = 48 },
                    new AlbumTrack { AlbumID = 4, TrackID = 49 },
                    new AlbumTrack { AlbumID = 4, TrackID = 50 },
                    new AlbumTrack { AlbumID = 4, TrackID = 51 },
                    new AlbumTrack { AlbumID = 4, TrackID = 52 },
                    new AlbumTrack { AlbumID = 4, TrackID = 53 },
                    new AlbumTrack { AlbumID = 4, TrackID = 54 },
                    new AlbumTrack { AlbumID = 4, TrackID = 55 },
                    new AlbumTrack { AlbumID = 4, TrackID = 56 }
                );

            modelBuilder.Entity<Genre>()
                .HasData
                (
                    new Genre { ID = 1, Name = "Rock" },
                    new Genre { ID = 2, Name = "Rap" },
                    new Genre { ID = 3, Name = "Hip-Hop" },
                    new Genre { ID = 4, Name = "Pop" },
                    new Genre { ID = 5, Name = "Metal" }
                );

            modelBuilder.Entity<Playlist>()
                .HasData
                (
                    new Playlist
                    {
                        ID = 1,
                        Name = "Test Playlist 1",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Playlists/playlist.jpg"),
                        UserID = 3,
                        CreatedAt = DateTime.Now
                    },
                    new Playlist
                    {
                        ID = 2,
                        Name = "Test Playlist 2",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Playlists/playlist.jpg"),
                        UserID = 4,
                        CreatedAt = DateTime.Now
                    },
                    new Playlist
                    {
                        ID = 3,
                        Name = "Test Playlist 1",
                        Image = FileHelper.ReadFile("SeedFiles/Images/Playlists/playlist.jpg"),
                        UserID = 5,
                        CreatedAt = DateTime.Now
                    }
                );

            modelBuilder.Entity<PlaylistTrack>()
                .HasData
                (
                    new PlaylistTrack { PlaylistID = 1, TrackID = 1 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 3 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 5 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 7 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 16 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 18 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 20 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 22 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 33 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 37 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 1 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 3 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 5 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 7 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 16 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 18 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 20 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 22 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 33 },
                    new PlaylistTrack { PlaylistID = 2, TrackID = 37 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 1 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 3 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 5 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 7 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 16 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 18 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 20 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 22 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 33 },
                    new PlaylistTrack { PlaylistID = 3, TrackID = 37 }
                );

            modelBuilder.Entity<UserTrackReview>()
                .HasData
                (
                    new UserTrackReview { ID = 1, UserID = 3, TrackID = 1, Score = 5 },
                    new UserTrackReview { ID = 2, UserID = 3, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 3, UserID = 3, TrackID = 3, Score = 4 },
                    new UserTrackReview { ID = 4, UserID = 3, TrackID = 4, Score = 4 },
                    new UserTrackReview { ID = 5, UserID = 3, TrackID = 5, Score = 5 },

                    new UserTrackReview { ID = 6, UserID = 4, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 7, UserID = 4, TrackID = 3, Score = 5 },
                    new UserTrackReview { ID = 8, UserID = 4, TrackID = 7, Score = 3 },
                    new UserTrackReview { ID = 9, UserID = 4, TrackID = 26, Score = 2 },

                    new UserTrackReview { ID = 10, UserID = 5, TrackID = 2, Score = 3 },
                    new UserTrackReview { ID = 11, UserID = 5, TrackID = 16, Score = 2 },

                    new UserTrackReview { ID = 12, UserID = 6, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 13, UserID = 6, TrackID = 14, Score = 3 },
                    new UserTrackReview { ID = 14, UserID = 6, TrackID = 17, Score = 3 },

                    new UserTrackReview { ID = 15, UserID = 7, TrackID = 3, Score = 4 },
                    new UserTrackReview { ID = 16, UserID = 7, TrackID = 32, Score = 1 },

                    new UserTrackReview { ID = 17, UserID = 8, TrackID = 4, Score = 4 },
                    new UserTrackReview { ID = 18, UserID = 8, TrackID = 23, Score = 2 },

                    new UserTrackReview { ID = 19, UserID = 9, TrackID = 4, Score = 5 },
                    new UserTrackReview { ID = 20, UserID = 9, TrackID = 21, Score = 5 },

                    new UserTrackReview { ID = 21, UserID = 10, TrackID = 5, Score = 1 },
                    new UserTrackReview { ID = 22, UserID = 10, TrackID = 6, Score = 1 }
                );

            modelBuilder.Entity<UserActivityTrack>()
                .HasData
                (
                    new UserActivityTrack { ID = 1, UserID = 3, TrackID = 1, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 2, UserID = 3, TrackID = 2, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 3, UserID = 3, TrackID = 3, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 4, UserID = 3, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 5, UserID = 3, TrackID = 5, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 6, UserID = 3, TrackID = 6, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 7, UserID = 3, TrackID = 7, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 8, UserID = 3, TrackID = 8, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 9, UserID = 3, TrackID = 9, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 10, UserID = 3, TrackID = 10, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 11, UserID = 3, TrackID = 11, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 12, UserID = 3, TrackID = 12, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 13, UserID = 3, TrackID = 13, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 14, UserID = 3, TrackID = 14, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 15, UserID = 3, TrackID = 15, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 16, UserID = 3, TrackID = 16, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 17, UserID = 3, TrackID = 17, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 18, UserID = 4, TrackID = 2, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 19, UserID = 4, TrackID = 3, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 20, UserID = 4, TrackID = 7, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 21, UserID = 4, TrackID = 26, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 22, UserID = 4, TrackID = 6, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 23, UserID = 4, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 24, UserID = 4, TrackID = 8, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 25, UserID = 4, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 26, UserID = 4, TrackID = 6, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 27, UserID = 4, TrackID = 9, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 28, UserID = 4, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 29, UserID = 5, TrackID = 2, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 30, UserID = 5, TrackID = 16, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 31, UserID = 5, TrackID = 6, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 32, UserID = 5, TrackID = 31, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 33, UserID = 5, TrackID = 5, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 34, UserID = 5, TrackID = 34, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 35, UserID = 5, TrackID = 12, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 36, UserID = 5, TrackID = 13, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 37, UserID = 5, TrackID = 14, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 38, UserID = 5, TrackID = 27, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 39, UserID = 6, TrackID = 2, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 40, UserID = 6, TrackID = 14, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 41, UserID = 6, TrackID = 17, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 42, UserID = 6, TrackID = 35, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 43, UserID = 7, TrackID = 3, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 44, UserID = 7, TrackID = 32, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 45, UserID = 7, TrackID = 33, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 46, UserID = 7, TrackID = 34, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 47, UserID = 8, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 48, UserID = 8, TrackID = 23, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 49, UserID = 8, TrackID = 24, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 50, UserID = 8, TrackID = 25, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 51, UserID = 9, TrackID = 4, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 52, UserID = 9, TrackID = 21, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 53, UserID = 9, TrackID = 22, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 54, UserID = 9, TrackID = 23, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 55, UserID = 10, TrackID = 5, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 56, UserID = 10, TrackID = 6, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 57, UserID = 10, TrackID = 7, InteractedAt = DateTime.Now },
                    new UserActivityTrack { ID = 58, UserID = 10, TrackID = 8, InteractedAt = DateTime.Now }
                );

            modelBuilder.Entity<UserActivityAlbum>()
                .HasData
                (
                    new UserActivityAlbum { ID = 1, UserID = 3, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 2, UserID = 3, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 3, UserID = 3, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 4, UserID = 3, AlbumID = 4, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 5, UserID = 3, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 6, UserID = 4, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 7, UserID = 4, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 8, UserID = 4, AlbumID = 4, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 9, UserID = 4, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 10, UserID = 5, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 11, UserID = 5, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 12, UserID = 5, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 13, UserID = 6, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 14, UserID = 6, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 15, UserID = 6, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 16, UserID = 6, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 17, UserID = 7, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 18, UserID = 7, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 19, UserID = 7, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 20, UserID = 7, AlbumID = 4, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 21, UserID = 8, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 22, UserID = 8, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 23, UserID = 8, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 24, UserID = 8, AlbumID = 4, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 25, UserID = 9, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 26, UserID = 9, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 27, UserID = 9, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 28, UserID = 9, AlbumID = 4, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 29, UserID = 10, AlbumID = 1, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 30, UserID = 10, AlbumID = 2, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 31, UserID = 10, AlbumID = 3, InteractedAt = DateTime.Now },
                    new UserActivityAlbum { ID = 32, UserID = 10, AlbumID = 4, InteractedAt = DateTime.Now }
                );

            modelBuilder.Entity<UserActivityPlaylist>()
                .HasData
                (
                    new UserActivityPlaylist { ID = 1, UserID = 3, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 2, UserID = 3, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 3, UserID = 3, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 4, UserID = 3, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 5, UserID = 3, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 6, UserID = 4, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 7, UserID = 4, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 8, UserID = 4, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 9, UserID = 4, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 10, UserID = 5, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 11, UserID = 5, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 12, UserID = 5, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 13, UserID = 6, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 14, UserID = 6, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 15, UserID = 6, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 16, UserID = 6, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 17, UserID = 7, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 18, UserID = 7, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 19, UserID = 7, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 20, UserID = 7, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 21, UserID = 8, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 22, UserID = 8, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 23, UserID = 8, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 24, UserID = 8, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 25, UserID = 9, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 26, UserID = 9, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 27, UserID = 9, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 28, UserID = 9, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 29, UserID = 10, PlaylistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 30, UserID = 10, PlaylistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 31, UserID = 10, PlaylistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityPlaylist { ID = 32, UserID = 10, PlaylistID = 1, InteractedAt = DateTime.Now }
                );

            modelBuilder.Entity<UserActivityArtist>()
                .HasData
                (
                    new UserActivityArtist { ID = 1, UserID = 3, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 2, UserID = 3, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 3, UserID = 3, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 4, UserID = 3, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 5, UserID = 3, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 6, UserID = 4, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 7, UserID = 4, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 8, UserID = 4, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 9, UserID = 4, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 10, UserID = 5, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 11, UserID = 5, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 12, UserID = 5, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 13, UserID = 6, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 14, UserID = 6, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 15, UserID = 6, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 16, UserID = 6, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 17, UserID = 7, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 18, UserID = 7, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 19, UserID = 7, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 20, UserID = 7, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 21, UserID = 8, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 22, UserID = 8, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 23, UserID = 8, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 24, UserID = 8, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 25, UserID = 9, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 26, UserID = 9, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 27, UserID = 9, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 28, UserID = 9, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 29, UserID = 10, ArtistID = 1, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 30, UserID = 10, ArtistID = 2, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 31, UserID = 10, ArtistID = 3, InteractedAt = DateTime.Now },
                    new UserActivityArtist { ID = 32, UserID = 10, ArtistID = 1, InteractedAt = DateTime.Now }
                );
        }
    }
}
