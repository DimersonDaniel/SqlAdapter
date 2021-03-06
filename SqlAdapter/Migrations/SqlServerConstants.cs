﻿namespace SqlAdapter.Migrations
{
    public class SqlServerConstants
    {
        public const string ID = "id";
        public const string CREATE_TABLE = "CREATE TABLE ";
        public const string UPDATE_TABLE = "ALTER TABLE ";
        public const string ADD_COLUMNS = "ADD ";
        public const string MIGRATIONS = "migrations";

        public const string INSERT_MIGRATIONS = "INSERT INTO migrations (name,created_at,updated_at) values (";
        public const string START_UPDATE_MIGRATIONS = "UPDATE migrations";
        public const string END_UPDATE_MIGRATIONS = "WHERE name = ";

        public const char SPACE = ' ';
        public const char EQUALS = '=';
        public const char START_PARENTHESIS = '(';
        public const char END_PARENTHESIS = ')';
        public const char COMMA = ',';
        public const char SINGLE_QUOTES = '\'';

        //SQL
        public const string SET = " SET";
        public const string NAME = "name";
        public const string CREATED_AT = "created_at";
        public const string UPDATED_AT = "updated_at";
        public const string NOTNULL = " NOT NULL";
        public const string IDENTITY_PRIMARY_KEY = " IDENTITY(1,1) PRIMARY KEY";

        public const string START_EXIST_TABLE = @"IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = ";

        public const string END_EXIST_TABLE = @"BEGIN
	                                                SELECT 'RESPONSE' = 1
                                                END
                                                    ELSE
                                                BEGIN 
                                                    SELECT 'RESPONSE' = 0
                                                END";

        public const string START_EXIST_PROCEDURE = @"IF EXISTS(SELECT * FROM sys.objects WHERE type = 'P' AND name = '";
        public const string MEIO_EXIST_PROCEDURE = @"')
                                                    BEGIN " ;
        public const string END_EXIST_DROP_PROCEDURE  =       "DROP PROCEDURE ";
        public const string END_EXIST_PROCEDURE       =   " END";

    }
}
