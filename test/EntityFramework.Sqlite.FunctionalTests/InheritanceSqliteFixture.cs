﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Data.Entity.FunctionalTests;
using Microsoft.Data.Entity.FunctionalTests.TestModels.Inheritance;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Relational.FunctionalTests;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    public class InheritanceSqliteFixture : InheritanceFixtureBase
    {
        private readonly DbContextOptions _options;
        private readonly IServiceProvider _serviceProvider;

        public InheritanceSqliteFixture()
        {
            _serviceProvider
                = new ServiceCollection()
                    .AddEntityFramework()
                    .AddSqlite()
                    .ServiceCollection()
                    .AddSingleton(TestSqliteModelSource.GetFactory(OnModelCreating))
                    .AddInstance<ILoggerFactory>(new TestSqlLoggerFactory())
                    .BuildServiceProvider();

            var testStore = SqliteTestStore.CreateScratch();

            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite(testStore.Connection);
            _options = optionsBuilder.Options;

            // TODO: Do this via migrations & update pipeline

            testStore.ExecuteNonQuery(@"
                CREATE TABLE Country (
                    Id int NOT NULL PRIMARY KEY,
                    Name nvarchar(100) NOT NULL
                );

                CREATE TABLE Animal (
                    Species nvarchar(100) NOT NULL PRIMARY KEY,
                    Name nvarchar(100) NOT NULL,
                    CountryId int NOT NULL FOREIGN KEY REFERENCES Country (Id),
                    IsFlightless bit NOT NULL,
                    EagleId nvarchar(100) FOREIGN KEY REFERENCES Animal (Species),
                    [Group] int,
                    FoundOn tinyint,
                    Discriminator nvarchar(255)
                );
                
                INSERT Country VALUES (1, 'New Zealand');
                INSERT Country VALUES (2, 'USA');

                INSERT Animal VALUES ('Aquila chrysaetos canadensis', 'American golden eagle', 2, 0, NULL, 1, NULL, 'Eagle');
                INSERT Animal VALUES ('Apteryx owenii', 'Great spotted kiwi', 1, 1, 'Aquila chrysaetos canadensis', NULL, 1, 'Kiwi');
            ");
        }

        public override AnimalContext CreateContext()
        {
            return new AnimalContext(_serviceProvider, _options);
        }

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: Code First this

            var animal = modelBuilder.Entity<Animal>().Metadata;

            var discriminatorProperty
                = animal.AddProperty("Discriminator", typeof(string), shadowProperty: true);

            animal.Relational().DiscriminatorProperty = discriminatorProperty;
        }
    }
}
