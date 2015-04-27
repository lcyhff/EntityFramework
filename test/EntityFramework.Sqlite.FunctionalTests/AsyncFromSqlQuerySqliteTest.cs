// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.Data.Entity.Relational.FunctionalTests;
using Xunit;

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    public class AsyncFromSqlQuerySqliteTest : AsyncFromSqlQueryTestBase<NorthwindQuerySqliteFixture>
    {
        public AsyncFromSqlQuerySqliteTest(NorthwindQuerySqliteFixture fixture)
            : base(fixture)
        {
        }

        [Fact(Skip = "Fails on SQLite")]
        public override Task From_sql_queryable_where_simple_closure_via_query_cache() =>
            base.From_sql_queryable_where_simple_closure_via_query_cache();
    }
}
