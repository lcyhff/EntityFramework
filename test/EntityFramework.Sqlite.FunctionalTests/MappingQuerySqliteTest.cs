// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Relational.FunctionalTests;
using Xunit;

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    public class MappingQuerySqliteTest : MappingQueryTestBase, IClassFixture<MappingQuerySqliteFixture>
    {


        private readonly MappingQuerySqliteFixture _fixture;

        public MappingQuerySqliteTest(MappingQuerySqliteFixture fixture)
        {
            _fixture = fixture;
        }

        protected override DbContext CreateContext()
        {
            return _fixture.CreateContext();
        }


    }
}
