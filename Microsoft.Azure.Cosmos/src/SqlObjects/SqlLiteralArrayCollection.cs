﻿//-----------------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------------------------------------------------------------------------------------
namespace Microsoft.Azure.Cosmos.Sql
{
    internal sealed class SqlLiteralArrayCollection : SqlCollection
    {
        public SqlScalarExpression[] Items
        {
            get;
            private set;
        }

        SqlLiteralArrayCollection(SqlScalarExpression[] items)
            : base(SqlObjectKind.LiteralArrayCollection)
        {
            this.Items = items;
        }

        public override void AppendToBuilder(System.Text.StringBuilder builder)
        {
            builder.Append("[");
            for (int i = 0; i < this.Items.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append(", ");
                }
                
                this.Items[i].AppendToBuilder(builder);
            }
            builder.Append("]");
        }
    }
}
