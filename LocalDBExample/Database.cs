using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDBExample
{
    public static class Database
    {
        private static string dbFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "LocalDBExample"
        );

        private static string dbPath = Path.Combine(dbFolder, "app.db");

        private static string connectionString => $"Data Source={dbPath}";

        public static void Initialize()
        {
            if (!Directory.Exists(dbFolder))
                Directory.CreateDirectory(dbFolder);

            if (!File.Exists(dbPath))
                File.Create(dbPath).Close();

            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Age INTEGER,
                Salary DOUBLE,
                Password TEXT
            );
            ";
            cmd.ExecuteNonQuery();
        }

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}
