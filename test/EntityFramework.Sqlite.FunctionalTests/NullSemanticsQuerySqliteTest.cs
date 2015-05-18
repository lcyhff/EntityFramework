﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.FunctionalTests;
//using Microsoft.Data.Entity.Relational.FunctionalTests;
//using Xunit;

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    // TODO: 3 failed
    public class NullSemanticsQuerySqliteTest : NullSemanticsQueryTestBase<SqliteTestStore, NullSemanticsQuerySqliteFixture>
    {
        public NullSemanticsQuerySqliteTest(NullSemanticsQuerySqliteFixture fixture)
            : base(fixture)
        {
        }

//        public override void Compare_bool_with_bool_equal()
//        {
//            base.Compare_bool_with_bool_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[NullableBoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableBoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_bool_equal()
//        {
//            base.Compare_negated_bool_with_bool_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_negated_bool_equal()
//        {
//            base.Compare_bool_with_negated_bool_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_negated_bool_equal()
//        {
//            base.Compare_negated_bool_with_negated_bool_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_bool_equal_negated()
//        {
//            base.Compare_bool_with_bool_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_bool_equal_negated()
//        {
//            base.Compare_negated_bool_with_bool_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_negated_bool_equal_negated()
//        {
//            base.Compare_bool_with_negated_bool_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_negated_bool_equal_negated()
//        {
//            base.Compare_negated_bool_with_negated_bool_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_bool_not_equal()
//        {
//            base.Compare_bool_with_bool_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_bool_not_equal()
//        {
//            base.Compare_negated_bool_with_bool_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_negated_bool_not_equal()
//        {
//            base.Compare_bool_with_negated_bool_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_negated_bool_not_equal()
//        {
//            base.Compare_negated_bool_with_negated_bool_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] OR [e].[NullableBoolB] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_bool_not_equal_negated()
//        {
//            base.Compare_bool_with_bool_not_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[NullableBoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableBoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_bool_not_equal_negated()
//        {
//            base.Compare_negated_bool_with_bool_not_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_bool_with_negated_bool_not_equal_negated()
//        {
//            base.Compare_bool_with_negated_bool_not_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] <> [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] <> [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] <> [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_negated_bool_with_negated_bool_not_equal_negated()
//        {
//            base.Compare_negated_bool_with_negated_bool_not_equal_negated();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[BoolA] = [e].[BoolB]

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[BoolA] = [e].[NullableBoolB] AND [e].[NullableBoolB] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableBoolA] = [e].[BoolB] AND [e].[NullableBoolA] IS NOT NULL)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (([e].[NullableBoolA] = [e].[NullableBoolB] AND ([e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL)) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))",
//                Sql);
//        }

//        public override void Compare_complex_equal_equal_equal()
//        {
//            base.Compare_complex_equal_equal_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[NullableBoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    [e].[IntA] = [e].[NullableIntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    ([e].[NullableIntA] = [e].[NullableIntB] OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_complex_equal_not_equal_equal()
//        {
//            base.Compare_complex_equal_not_equal_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[NullableBoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    [e].[IntA] = [e].[NullableIntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] = [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    ([e].[NullableIntA] = [e].[NullableIntB] OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_complex_not_equal_equal_equal()
//        {
//            base.Compare_complex_not_equal_equal_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    ([e].[IntA] = [e].[NullableIntB] AND [e].[NullableIntB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    (([e].[NullableIntA] = [e].[NullableIntB] AND ([e].[NullableIntA] IS NOT NULL AND [e].[NullableIntB] IS NOT NULL)) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_complex_not_equal_not_equal_equal()
//        {
//            base.Compare_complex_not_equal_not_equal_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    ([e].[IntA] = [e].[NullableIntB] AND [e].[NullableIntB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    (([e].[NullableIntA] = [e].[NullableIntB] AND ([e].[NullableIntA] IS NOT NULL AND [e].[NullableIntB] IS NOT NULL)) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_complex_not_equal_equal_not_equal()
//        {
//            base.Compare_complex_not_equal_equal_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    [e].[IntA] <> [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    ([e].[IntA] <> [e].[NullableIntB] OR [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
//    (([e].[NullableIntA] <> [e].[NullableIntB] OR ([e].[NullableIntA] IS NULL OR [e].[NullableIntB] IS NULL)) AND ([e].[NullableIntA] IS NOT NULL OR [e].[NullableIntB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_complex_not_equal_not_equal_not_equal()
//        {
//            base.Compare_complex_not_equal_not_equal_not_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    [e].[IntA] <> [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    ([e].[NullableBoolA] <> [e].[BoolB] OR [e].[NullableBoolA] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    ([e].[IntA] <> [e].[NullableIntB] OR [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (CASE WHEN (
//    (([e].[NullableBoolA] <> [e].[NullableBoolB] OR ([e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL)) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
//    (([e].[NullableIntA] <> [e].[NullableIntB] OR ([e].[NullableIntA] IS NULL OR [e].[NullableIntB] IS NULL)) AND ([e].[NullableIntA] IS NOT NULL OR [e].[NullableIntB] IS NOT NULL))) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
//                Sql);
//        }

//        public override void Compare_nullable_with_null_parameter_equal()
//        {
//            base.Compare_nullable_with_null_parameter_equal();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableStringA] IS NULL",
//                Sql);
//        }

//        public override void Compare_nullable_with_non_null_parameter_not_equal()
//        {
//            base.Compare_nullable_with_non_null_parameter_not_equal();

//            Assert.Equal(
//                @"__prm_0: Foo

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableStringA] = @__prm_0",
//                Sql);
//        }

//        public override void Join_uses_database_semantics()
//        {
//            base.Join_uses_database_semantics();

//            Assert.Equal(
//                @"SELECT [e1].[Id], [e2].[Id], [e1].[NullableIntA], [e2].[NullableIntB]
//FROM [NullSemanticsEntity1] AS [e1]
//INNER JOIN [NullSemanticsEntity2] AS [e2] ON [e1].[NullableIntA] = [e2].[NullableIntB]",
//                Sql);
//        }

//        public override void Contains_with_local_array_closure_with_null()
//        {
//            base.Contains_with_local_array_closure_with_null();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] IN ('Foo') OR [e].[NullableStringA] IS NULL)",
//                Sql);
//        }

//        public override void Contains_with_local_array_closure_false_with_null()
//        {
//            base.Contains_with_local_array_closure_false_with_null();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] NOT IN ('Foo') AND [e].[NullableStringA] IS NOT NULL)",
//                Sql);
//        }

//        public override void Contains_with_local_array_closure_with_multiple_nulls()
//        {
//            base.Contains_with_local_array_closure_with_multiple_nulls();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] IN ('Foo') OR [e].[NullableStringA] IS NULL)",
//                Sql);
//        }

//        public override void Where_select_many_or_with_null()
//        {
//            base.Where_select_many_or_with_null();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] IN ('Foo', 'Blah') OR [e].[NullableStringA] IS NULL)",
//                Sql);
//        }

//        public override void Where_select_many_and_with_null()
//        {
//            base.Where_select_many_and_with_null();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] NOT IN ('Foo', 'Blah') AND [e].[NullableStringA] IS NOT NULL)",
//                Sql);
//        }

//        public override void Where_select_many_or_with_nullable_parameter()
//        {
//            base.Where_select_many_or_with_nullable_parameter();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] IN ('Foo') OR [e].[NullableStringA] IS NULL)",
//                Sql);
//        }

//        public override void Where_select_many_and_with_nullable_parameter_and_constant()
//        {
//            base.Where_select_many_and_with_nullable_parameter_and_constant();

//            Assert.Equal(
//                @"__prm3_2: Blah

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE ([e].[NullableStringA] NOT IN ('Foo', @__prm3_2) AND [e].[NullableStringA] IS NOT NULL)",
//                Sql);
//        }

//        public override void Where_select_many_and_with_nullable_parameter_and_constant_not_optimized()
//        {
//            base.Where_select_many_and_with_nullable_parameter_and_constant_not_optimized();

//            Assert.Equal(
//                @"__prm3_2: Blah

//SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE (((([e].[NullableStringB] IS NOT NULL AND ([e].[NullableStringA] <> 'Foo' OR [e].[NullableStringA] IS NULL)) AND [e].[NullableStringA] IS NOT NULL) AND [e].[NullableStringA] IS NOT NULL) AND ([e].[NullableStringA] <> @__prm3_2 OR [e].[NullableStringA] IS NULL))",
//                Sql);
//        }

//        public override void Where_select_equal_nullable_with_null_value_parameter()
//        {
//            base.Where_select_equal_nullable_with_null_value_parameter();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableStringA] IS NULL",
//                Sql);
//        }

//        public override void Where_select_not_equal_nullable_with_null_value_parameter()
//        {
//            base.Where_select_not_equal_nullable_with_null_value_parameter();

//            Assert.Equal(
//                @"SELECT [e].[Id]
//FROM [NullSemanticsEntity1] AS [e]
//WHERE [e].[NullableStringA] IS NOT NULL",
//                Sql);
//        }

//        private static string Sql
//        {
//            get { return TestSqlLoggerFactory.Sql; }
//        }
    }
}

