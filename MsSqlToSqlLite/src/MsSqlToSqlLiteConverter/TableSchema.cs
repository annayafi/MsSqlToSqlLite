namespace MsSqlToSqlLiteConverter
{
    using System.Collections.Generic;

    public class TableSchema
    {
        public string TableName;

        public string TableSchemaName;

        public List<ColumnSchema> Columns;

        public List<string> PrimaryKey;

    	public List<ForeignKeySchema> ForeignKeys;

        public List<IndexSchema> Indexes;
    }
}
