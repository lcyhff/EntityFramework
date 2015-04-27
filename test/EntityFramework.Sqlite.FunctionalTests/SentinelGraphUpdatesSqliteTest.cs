// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    // TODO: 96 failed
    public class SentinelGraphUpdatesSqliteTest : GraphUpdatesSqliteTestBase<SentinelGraphUpdatesSqliteTest.SentinelGraphUpdatesSqliteFixture>
    {
        public SentinelGraphUpdatesSqliteTest(SentinelGraphUpdatesSqliteFixture fixture)
            : base(fixture)
        {
        }

        public class SentinelGraphUpdatesSqliteFixture : GraphUpdatesSqliteFixtureBase
        {
            protected override string DatabaseName => "SentinelGraphUpdatesTest";

            public override int IntSentinel => -1;

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // TODO: Was this needed?
                //modelBuilder.ForRelational().Sequence("StartAtZeroSequence").Start(0);
                //modelBuilder.ForSqlite().UseSequence("StartAtZeroSequence");

                SetSentinelValues(modelBuilder);
            }
        }
    }
}
